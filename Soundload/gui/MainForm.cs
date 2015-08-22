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
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json;
using HundredMilesSoftware.UltraID3Lib;


namespace SoundCloudDownloader
{
    public partial class MainForm : Form
    {
        public class Track
        {
            public string stream_url { get; set; }
            public string title { get; set; }
            public string artwork_url { get; set; }

            public User user { get; set; }

            public override string ToString()
            {
                return String.Format("{0}", title);
            }
        }

        public class User
        {
            public string username { get; set; }
        }

        public class Tracks
        {
            public List<Track> tracks { get; set; }
            public string kind { get; set; }
            public string title { get; set; }
        }


        private WebClient wbClient = new WebClient();
        private static XmlConfiguration configuration;
        private static readonly string m_Direcotry = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "SoundCloud");
        private string downloadFolder, tempDownloadFolder, playlistTitle;
        private int totalTracksCount, tracksCount;
        private bool isPlaylist, path, artist, image, openFolder, skip;


        public MainForm()
        {
            InitializeComponent();

            Directory.CreateDirectory(m_Direcotry);
            wbClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(Client_DownloadStringCompleted);

            ThreadPool.QueueUserWorkItem((_) => { });
            LoadConfiguration();

        }

        private void LoadConfiguration()
        {
            configuration = new XmlConfiguration("config.xml");
            configuration.LoadConfigurationFile();

            downloadFolder = configuration.GetConfiguration("path");
            path = Convert.ToBoolean(Convert.ToInt32(configuration.GetConfiguration("setPath")));
            artist = Convert.ToBoolean(Convert.ToInt32(configuration.GetConfiguration("setArtist")));
            image = Convert.ToBoolean(Convert.ToInt32(configuration.GetConfiguration("setImage")));
            openFolder = Convert.ToBoolean(Convert.ToInt32(configuration.GetConfiguration("setOpenFolder")));
            skip = Convert.ToBoolean(Convert.ToInt32(configuration.GetConfiguration("skip")));

            chkBxDownloadPath.Checked = path;
            chkBxArtistTag.Checked = artist;
            chkBxImageTags.Checked = image;
            chkBxOpenFolder.Checked = openFolder;
            chkBxSkip.Checked = skip;

            txtBxPath.Text = downloadFolder;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            configuration.SetConfigurationEntry("setPath", (Convert.ToInt32(chkBxDownloadPath.Checked)).ToString());
            configuration.SetConfigurationEntry("setArtist", (Convert.ToInt32(chkBxArtistTag.Checked)).ToString());
            configuration.SetConfigurationEntry("setImage", (Convert.ToInt32(chkBxImageTags.Checked)).ToString());
            configuration.SetConfigurationEntry("setOpenFolder", (Convert.ToInt32(chkBxOpenFolder.Checked)).ToString());
            configuration.SetConfigurationEntry("skip", (Convert.ToInt32(chkBxSkip.Checked)).ToString());
            configuration.SetConfigurationEntry("path", downloadFolder);
            configuration.SaveConfigurationFile();
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
                label1.Text = bytes;
            }
        }



        private void m_tbxPage_TextChanged(object sender, EventArgs e)
        {
            if (txtBxUrl.Text != "")
            {
                string uri;
                uri = txtBxUrl.Text;

                if (!uri.ToLower().StartsWith("https://soundcloud.com"))
                {
                    MessageBox.Show("No correct soundcloud URL or link!");
                    txtBxUrl.Text = "";
                    txtBxUrl.Placeholder = "Put your Soundcloud playlist or track link here!";
                    return;
                }
                if (txtBxUrl.Text.Contains("sets")) 
                {
                    isPlaylist = true;
                }
                else 
                {
                    isPlaylist = false;
                }

                SetEnabled(false);
                m_tslInfo.Text = "Loading Playlist information";
                m_lbxEntries.Items.Clear();
                string url = string.Format("http://api.soundcloud.com/resolve.json?url={0}&client_id=YOUR_CLIENT_ID", txtBxUrl.Text);
                wbClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                wbClient.DownloadStringAsync(new Uri(url));
            }
        }

        private void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                int count = 0;
                ThreadPool.QueueUserWorkItem(
                (_) =>
                {
                    if (isPlaylist)
                    {
                        Tracks playlist = JsonConvert.DeserializeObject<Tracks>(e.Result);
                        playlistTitle = playlist.title;

                        foreach (var track in playlist.tracks)
                        {
                            if (track.stream_url != null)
                            {
                                AddItem(track);
                                ++count;
                            }
                            else 
                            {
                                lbxErrorLog.Items.Add(track.title + " -> track is not streamable and cannot be downloaded!");                            
                            }
                        }
                    }
                    else
                    {
                        Track track = JsonConvert.DeserializeObject<Track>(e.Result);
                        if (track.stream_url != null)
                        {
                            AddItem(track);
                            ++count;
                        }
                        else
                        {
                            lbxErrorLog.Items.Add(track.title + " -> track is not streamable and cannot be downloaded!");
                        }
                       
                    }     
                       
                    SetEnabled(true);
                    SetInfo(String.Format("Found {0} Tracks!", count));
                });
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

            SetLablStatus((bytesIn / 1000000).ToString("0.##") + "/" + (totalBytes / 1000000).ToString("0.##") + " MB ("+ tracksCount + "/" + totalTracksCount.ToString() + ")");
            SetProgressbar(int.Parse(Math.Truncate(percentage).ToString()));
        }

        public void HandleDownloadComplete(object sender, AsyncCompletedEventArgs args)
        {
            lock (args.UserState)
            {
                Monitor.Pulse(args.UserState);
            }
        }



        private void btnDownloadSelectedClick(object sender, EventArgs e)
        {
            string finalPath;
            SetEnabled(false);
            SetInfo("Downloading Songs");
            totalTracksCount = m_lbxEntries.CheckedItems.Count;
            var tracks = m_lbxEntries.CheckedItems.Cast<Track>();

            if (chkBxDownloadPath.Checked)
            {
                finalPath = downloadFolder;
            }
            else
            {
                finalPath = m_Direcotry;
            }

            if (isPlaylist)
            {
                finalPath = Path.Combine(finalPath, playlistTitle);
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

                        string url = String.Format("{0}.json?client_id=YOUR_CLIENT_ID", track.stream_url);
                        wbClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                        wbClient.DownloadFileCompleted += HandleDownloadComplete;

                        var syncObject = new Object();
                        lock (syncObject)
                        {
                            wbClient.DownloadFileAsync(new Uri(url), tempDownloadFolder, syncObject);
                            Monitor.Wait(syncObject);
                        }

                        var u = new UltraID3();
                        u.Read(tempDownloadFolder);
                        if (chkBxArtistTag.Checked)
                        {
                            User usr = track.user;
                            u.Artist = ((User)track.user).username;
                        }
                        if (track.artwork_url != null && chkBxImageTags.Checked)
                        {
                            Stream stream = wbClient.OpenRead(track.artwork_url);
                            Bitmap bmp = new Bitmap(stream);

                            var pictureFrame = new ID3v23PictureFrame(bmp, PictureTypes.CoverFront, "image", TextEncodingTypes.ISO88591);
                            u.ID3v2Tag.Frames.Add(pictureFrame);
                        }
                        u.Write();
                    }

                    SetInfo("Finished Downloading!");
                    SetEnabled(true);
                    SetChecked(false);
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
        private void SetChecked(bool check)
        {
            for (int i = 0; i < m_lbxEntries.Items.Count; i++)
            {
                m_lbxEntries.SetItemChecked(i, check);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            m_lbxEntries.Items.Clear();
            txtBxUrl.Text = "";
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
    }
}
