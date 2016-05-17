using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Drawing;
using System.Xml;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;
using HundredMilesSoftware.UltraID3Lib;



namespace SoundCloudDownloader
{
    public partial class MainForm : Form
    {
        public enum SearchType
        {
            TRACK, PLAYLIST, USERALL, SEARCH
        }

        public enum PlayerStatus
        {
            PLAY, PAUSE, STOP
        }

        public class Track
        {
            public string id { get; set; }
            public string uri { get; set; }
            public string title { get; set; }
            public string artwork_url { get; set; }
            public string streamurl { get { return String.Format("{0}/stream.json?client_id={1}", uri, clientID); } }
            public bool streamable { get; set; }

            public User user { get; set; }

            public override string ToString()
            {
                return String.Format("{0}", title);
            }
        }

        public class User
        {
            public string username { get; set; }
            public string id { get; set; }
        }


        public class RootPlaylist
        {
            public List<Track> tracks { get; set; }
            public string kind { get; set; }
            public string title { get; set; }
        }

        public class RootCollection
        {
            public List<Collection> collection { get; set; }
        }

        public class Collection
        {
            public Track track { get; set; }
            public string type { get; set; }
        }

        public class StreamUrl
        {
            public string http_mp3_128_url { get; set; }
        }

        private Properties.Settings settings = Properties.Settings.Default;
        private WebClient wbClient = new WebClient();
        private AudioStreamPlayer Player = new AudioStreamPlayer();
        private static readonly string m_Direcotry = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "Soundcloud");
        private static readonly string saveDirectory = Path.GetTempPath() + "/LinkList.xml";
        private static readonly string clientID = "376f225bf427445fc4bfb6b99b72e0bf"; // old = 06e3e204bdd61a0a41d8eaab895cb7df
        private string downloadFolder, tempDownloadFolder, title;
        private int totalTracksCount, tracksCount;
        private bool repeat, random;

        private SearchType type;
        private PlayerStatus status = PlayerStatus.STOP;


        public MainForm()
        {
            InitializeComponent();

            wbClient.Proxy = null;
            Directory.CreateDirectory(m_Direcotry);
            wbClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Client_DownloadStringCompleted);
            trackBar1.Scroll += new EventHandler(SliderOnChanged);
            timer.Tick += TimerOnTick;

            ThreadPool.QueueUserWorkItem((_) => { });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chkBxDownloadPath.Checked = settings.Path;
            chkBxArtistTag.Checked = settings.Artist;
            chkBxImageTags.Checked = settings.Cover;
            chkBxOpenFolder.Checked = settings.OpenFolder;
            chkBxSkip.Checked = settings.Skip;

            downloadFolder = settings.DownloadPath;
            txtBxPath.Text = downloadFolder;
            LoadListsToCombobox();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings.Path = chkBxDownloadPath.Checked;
            settings.Artist = chkBxArtistTag.Checked;
            settings.Cover = chkBxImageTags.Checked;
            settings.OpenFolder = chkBxOpenFolder.Checked;
            settings.Skip = chkBxSkip.Checked;
            settings.DownloadPath = txtBxPath.Text;
            settings.Save();
        }


        private void SetInfo(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<String>(SetInfo), text);
            }
            else
            {
                m_tslInfo.Text = text;
            }
        }

        private void AddItem(Track entry)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Track>(AddItem), entry);
            }
            else
            {
                m_lbxEntries.Items.Add(entry);
            }
        }

        private void SetEnabled(bool enabled)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(SetEnabled), enabled);
            }
            else
            {
                m_pnlContent.Enabled = enabled;
            }
        }

        private void SetProgressbar(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(SetProgressbar), value);
            }
            else
            {
                progressBar1.Value = value;
            }
        }

        private void SetLablStatus(string bytes)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(SetLablStatus), bytes);
            }
            else
            {
                lablDownloadedBytes.Text = bytes;
            }
        }

        private void SetChecked(bool check)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(SetChecked), check);
            }
            else
            {
                for (int i = 0; i < m_lbxEntries.Items.Count; i++)
                {
                    m_lbxEntries.SetItemChecked(i, check);
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string url = txtBxUrl.Text;
            title = "";

            if (txtBxUrl.Text != "")
            {
                type = SearchType.TRACK;

                if (!url.ToLower().StartsWith("https://soundcloud.com"))
                {
                    type = SearchType.SEARCH;
                }
                if (txtBxUrl.Text.Contains("sets"))
                {
                    type = SearchType.PLAYLIST;
                }
                Regex regex = new Regex("^.+?(soundcloud.com\\/[^\\/\\?]+?)\\/?$", RegexOptions.Multiline);
                if (regex.IsMatch(url))
                {
                    type = SearchType.USERALL;
                }
                ScApiLoadJson(url);
            }
        }

        private void ScApiLoadJson(string pUrl)
        {
            string url = pUrl;
            User user = new User();

            SetEnabled(false);
            m_tslInfo.Text = "Loading Tracks ...";
            if (!chkBxKeepTracks.Checked)
            {
                m_lbxEntries.Items.Clear();
            }
           
            if (type == SearchType.USERALL)
            {
                string userJson = wbClient.DownloadString(string.Format("http://api.soundcloud.com/resolve.json?url={0}&client_id={1}", url, clientID));
                user = JsonConvert.DeserializeObject<User>(userJson);
                if (title != "")
                {
                    title = user.username;
                    lablTitle.Text = title;
                }
            }

            string tmpUrl = url;
            switch (type)
            {
                case SearchType.TRACK:
                case SearchType.PLAYLIST:
                    url = string.Format("http://api.soundcloud.com/resolve.json?url={0}&client_id={1}", tmpUrl, clientID);
                    break;
                case SearchType.USERALL:
                    url = string.Format("https://api-v2.soundcloud.com/profile/soundcloud%3Ausers%3A{0}?limit=1000&client_id={1}", user.id, clientID);
                    break;
                case SearchType.SEARCH:
                    url = string.Format("http://api.soundcloud.com/tracks.json?client_id={1}&q={0}&limit=200", tmpUrl, clientID);
                    break;
            }

            wbClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            wbClient.DownloadStringAsync(new Uri(url));
        }


        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                int count = 0;
                switch (type)
                {
                    case SearchType.TRACK:
                        Track singleTrack = JsonConvert.DeserializeObject<Track>(e.Result);
                        if (singleTrack.streamable)
                        {
                            AddItem(singleTrack);
                            ++count;
                        }
                        else
                        {
                            lbxErrorLog.Items.Add(singleTrack.title + " -> track is not streamable and cannot be downloaded!");
                        }
                        break;
                    case SearchType.PLAYLIST:
                        RootPlaylist playlist = JsonConvert.DeserializeObject<RootPlaylist>(e.Result);
                        title = playlist.title;
                        lablTitle.Text = title;
                        foreach (var track in playlist.tracks)
                        {
                            //if (track.streamable)
                            //{
                            //    AddItem(track);
                            //    ++count;
                            //}
                            //else
                            //{
                            //    lbxErrorLog.Items.Add(track.title + " -> track is not streamable and cannot be downloaded!");
                            //}
                            AddItem(track);
                            ++count;
                        }
                        break;
                    case SearchType.USERALL:
                        RootCollection collection = JsonConvert.DeserializeObject<RootCollection>(e.Result);
                        foreach (var item in collection.collection)
                        {
                            if (item.type == "track" || item.type == "track-repost") //(item.type != "playlist" || item.type != "playlist-repost")
                            {
                                if (item.track.streamable)
                                {
                                    AddItem(item.track);
                                    ++count;
                                }
                                else
                                {
                                    lbxErrorLog.Items.Add(item.track.title + " -> track is not streamable and cannot be downloaded!");
                                }
                            }
                        }
                        break;
                    case SearchType.SEARCH:
                        Track[] tracklist = JsonConvert.DeserializeObject<Track[]>(e.Result);
                        int i = 0;
                        foreach (var track in tracklist)
                        {
                            if (track.streamable)
                            {
                                AddItem(track);
                                ++count;
                            }
                            else
                            {
                                lbxErrorLog.Items.Add(track.title + " -> track is not streamable and cannot be downloaded!");
                            }
                            i++;
                        }
                        break;
                }
                lablTitle.Text = title;
                SetEnabled(true);
                SetInfo(String.Format("{0} Tracks Found!", count));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            SetLablStatus((bytesIn / 1000000).ToString("0.##") + "/" + (totalBytes / 1000000).ToString("0.##") + " MB (" + tracksCount + "/" + totalTracksCount.ToString() + ")");
            SetProgressbar(int.Parse(Math.Truncate(percentage).ToString()));
        }

        public void HandleDownloadComplete(object sender, AsyncCompletedEventArgs args)
        {
            lock (args.UserState)
            {
                Monitor.Pulse(args.UserState);
            }
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string finalPath;
            SetEnabled(false);
            SetInfo("Downloading Songs ...");
            totalTracksCount = m_lbxEntries.CheckedItems.Count;
            List<Track> tracks = m_lbxEntries.CheckedItems.Cast<Track>().ToList();

            if (chkBxDownloadPath.Checked)
            {
                finalPath = downloadFolder;
            }
            else
            {
                finalPath = m_Direcotry;
            }

            if (type != SearchType.TRACK)
            {
                finalPath = Path.Combine(finalPath, title);
                if (!System.IO.Directory.Exists(finalPath))
                {
                    System.IO.Directory.CreateDirectory(finalPath);
                }
            }

            ThreadPool.QueueUserWorkItem(
                 (_) =>
                 {
                     foreach (var track in tracks)
                     {
                         string fileName = String.Format("{0}.mp3", track.title);
                         foreach (var chr in Path.GetInvalidFileNameChars().Union(Path.GetInvalidPathChars()))
                         {
                             fileName = fileName.Replace("" + chr, "_");
                         }

                         SetInfo("Downloading " + fileName);
                         tracksCount++;

                         tempDownloadFolder = Path.Combine(finalPath, fileName);

                         if (File.Exists(tempDownloadFolder))
                         {
                             if (chkBxSkip.Checked)
                             {
                                 continue;
                             }
                             else
                             {
                                 File.Delete(tempDownloadFolder);
                             }
                         }

                        // string streamurl = client.DownloadString(new Uri(string.Format("http://api.soundcloud.com/i1/tracks/{0}/streams?client_id={1}", track.id, clientID)));
                        
                         wbClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                         wbClient.DownloadFileCompleted += HandleDownloadComplete;

                         var syncObject = new Object();
                         lock (syncObject)
                         {
                             wbClient.DownloadFileAsync(new Uri(track.streamurl), tempDownloadFolder, syncObject);
                             Monitor.Wait(syncObject);
                         }

                         var u = new UltraID3();
                         u.Read(tempDownloadFolder);

                         if (track.artwork_url != null && chkBxImageTags.Checked)
                         {
                             Stream stream = wbClient.OpenRead(track.artwork_url);
                             Bitmap bmp = new Bitmap(stream);

                             var pictureFrame = new ID3v23PictureFrame(bmp, PictureTypes.CoverFront, "image", TextEncodingTypes.ISO88591);
                             u.ID3v2Tag.Frames.Add(pictureFrame);
                         }

                         string[] splitTitle = null;
                         if (track.title.Contains("-"))
                         {
                             splitTitle = track.title.Split('-');
                             u.Title = splitTitle[1];
                         }
                         if (chkBxArtistTag.Checked)
                         {
                             if (splitTitle != null)
                             {
                                 u.Artist = splitTitle[0];
                             }
                             else
                             {
                                 u.Artist = ((User)track.user).username;
                             }
                         }
                         u.Write();
                     }

                     SetInfo("Finished Downloading!");
                     SetEnabled(true);
                     SetChecked(false);
                     totalTracksCount = 0;
                     tracksCount = 0;
                     if (chkBxOpenFolder.Checked)
                     {
                         System.Diagnostics.Process.Start("explorer.exe", finalPath);
                     }
                 });
        }

        


        private void chkBxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkBxSelectAll.Checked)
            {
                SetChecked(false);
            }
            else
            {
                SetChecked(true);
            }
        }


        private void chkBxDownloadPath_CheckedChanged(object sender, EventArgs e)
        {
            btnChoosePath.Enabled = chkBxDownloadPath.Checked;
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                downloadFolder = dialog.SelectedPath;
                txtBxPath.Text = downloadFolder;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBxUrl.Text == "")
            {
                return;
            }
            form_Inputbox InputBox = new form_Inputbox();
            if (InputBox.ShowDialog() == DialogResult.OK)
            {
                XmlDocument doc = new XmlDocument();
                if (!File.Exists(saveDirectory))
                {
                    XmlNode myRoot;
                    myRoot = doc.CreateElement("LinkList");
                    doc.AppendChild(myRoot);
                    doc.Save(@Path.GetTempPath() + "/LinkList.xml");
                }

                doc.Load(saveDirectory);
                XmlNode root = doc.DocumentElement;
                XmlElement Link = doc.CreateElement("Link");

                XmlElement name = doc.CreateElement("Name");
                name.InnerText = InputBox.getName;
                XmlElement type1 = doc.CreateElement("Type");
                type1.InnerText = type.ToString();
                XmlElement url = doc.CreateElement("Url");
                url.InnerText = txtBxUrl.Text;

                Link.AppendChild(name);
                Link.AppendChild(type1);
                Link.AppendChild(url);
                root.AppendChild(Link);
                doc.Save(saveDirectory);
            }
            LoadListsToCombobox();
        }

        private void LoadListsToCombobox()
        {
            comboBxSavePlaylists.Items.Clear();
            XmlReader reader = XmlReader.Create(saveDirectory);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Name")
                {
                    comboBxSavePlaylists.Items.Add(reader.ReadString());
                }
            }
            reader.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            bool stop = false;
            string name = "";
            XmlReader reader = XmlReader.Create(saveDirectory);

            while (reader.Read() && !stop)
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    switch (reader.Name)
                    {
                        case "Name":
                            name = reader.ReadString();
                            break;
                        case "Type":
                            if (name == comboBxSavePlaylists.Text)
                            {
                                type = (SearchType)Enum.Parse(typeof(SearchType), reader.ReadString());
                            }
                            break;
                        case "Url":
                            if (name == comboBxSavePlaylists.Text)
                            {
                                ScApiLoadJson(reader.ReadString());
                                title = name;
                                lablTitle.Text = title;
                                stop = true;
                            }
                            break;
                    }
                }
            }
            reader.Close();
        }


        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            if (Player.reader != null)
            {
                trackBar1.Value = Player.TrackPosition;
                TimeSpan currentTime = Player.reader.CurrentTime;
                labelCurrentTime.Text = String.Format("{0:00}:{1:00} ", (int)currentTime.TotalMinutes, currentTime.Seconds);
            }
            if(Player.next)
            {
                Player.next = false;
                if (repeat)
                {
                    PlayTrack(0);
                }
                else if (random)
                {
                    PlayTrack(new Random().Next(m_lbxEntries.Items.Count),true);
                }
                else if (!random)
                {
                    if (m_lbxEntries.SelectedIndex != m_lbxEntries.Items.Count - 1)
                    {
                        PlayTrack(1);
                    }
                }
            }
        }

        private void SliderOnChanged(object sender, System.EventArgs e)
        {
            Player.TrackPosition = trackBar1.Value;
        }



        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (m_lbxEntries.Items.Count == 0)
            {
                return;
            }
            if (m_lbxEntries.SelectedItem == null)
            {
                m_lbxEntries.SetSelected(0, true);
            }

            if (status == PlayerStatus.STOP || status == PlayerStatus.PAUSE)
            {
                btnPlay.Image = Properties.Resources.Pause;
                btnPlay.ToolTipText = "Pause";
                PlayTrack(0);
                status = PlayerStatus.PLAY;
            }
            else
            {
                btnPlay.Image = Properties.Resources.Play;
                btnPlay.ToolTipText = "Pause";
                status = PlayerStatus.PAUSE;
                Player.Pause();
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            Player.Stop();
            timer.Stop();
            btnPlay.Image = Properties.Resources.Play;
            status = PlayerStatus.STOP;
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (m_lbxEntries.SelectedIndex != m_lbxEntries.Items.Count-1)
            {
                PlayTrack(1);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (m_lbxEntries.SelectedIndex != 0)
            {
                PlayTrack(-1);
            }
        }

        private void PlayTrack(int pos, bool random = false)
        {
            int position = 0;
            if (random)
            {
                position = pos;
            }
            else
            {
                position = m_lbxEntries.SelectedIndex + pos;
            }
            Track track = (Track)m_lbxEntries.Items[position];
            m_lbxEntries.SetSelected(position, true);
            if (pos == 0 && status != PlayerStatus.PAUSE)
            {
                Player.Play(track.streamurl, true);
            }
            else
            {
                Player.Play(track.streamurl);
            }
            labelTotalTime.Text = String.Format("{0:00}:{1:00}", (int)Player.reader.TotalTime.TotalMinutes, Player.reader.TotalTime.Seconds);
            SetInfo("Playing:  " + track.title);
            timer.Start();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            VolumeControl volCrtl = new VolumeControl();
            volCrtl.StartPosition = FormStartPosition.Manual;
            volCrtl.Location = new Point(this.Location.X + 450, this.Location.Y + (this.Height - volCrtl.Height) / 2);
            volCrtl.Show(this);
        }

        private void btnRandomTrack_Click(object sender, EventArgs e)
        {
            if (random)
            {
                random = false;
                btnRandomTrack.Image = Properties.Resources.Random;
            }
            else
            {
                random = true;
                btnRandomTrack.Image = Properties.Resources.RandomOn;
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (repeat)
            {
                repeat = false;
                btnLoop.Image = Properties.Resources.Loop;
            }
            else
            {
                repeat = true;
                btnLoop.Image = Properties.Resources.LoopOn;
            }
        }
    }
}
