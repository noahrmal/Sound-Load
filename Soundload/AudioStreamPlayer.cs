using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using NAudio.MediaFoundation;
using NAudio.Wave;

// Credtis to Naudio/NAudioWpfDemo:     https://github.com/naudio/NAudio/tree/master/NAudioWpfDemo/MediaFoundationPlayback
namespace SoundCloudDownloader
{
    class AudioStreamPlayer
    {
        private IWavePlayer wavePlayer;
        public WaveStream reader;
        const int SliderMax = 100;
        private string lastPlayed;
        public bool next;
        public bool repeat;

        public AudioStreamPlayer()
        {
            wavePlayer = new WaveOutEvent();
            wavePlayer.PlaybackStopped += WavePlayerOnPlaybackStopped;
        }

        public int TrackPosition
        {
            get { return (int)Math.Min(SliderMax, reader.Position * SliderMax / reader.Length); }
            set
            {
                if (reader != null)
                {
                    reader.Position = (long)(reader.Length * value / SliderMax);
                }
            }
        }


        public void Play(string streamurl, bool repeat=false)
        {
            if (reader != null && (repeat || lastPlayed != streamurl))
            {
                wavePlayer.Stop();
                reader.Dispose();
                reader = null;
            }
            if (reader == null)
            {
                reader = new MediaFoundationReader(streamurl);
                lastPlayed = streamurl;
                wavePlayer.Init(reader);
            }
            wavePlayer.Play();
        }

        public void Pause()
        {
            if (wavePlayer != null)
            {
                wavePlayer.Pause();
            }
        }

        public void Stop()
        {
            if (wavePlayer != null)
            {
                wavePlayer.Stop();
            }
        }


        private void WavePlayerOnPlaybackStopped(object sender, StoppedEventArgs stoppedEventArgs)
        {
            if (reader != null)
            {
                if (reader.CurrentTime.Minutes == reader.TotalTime.Minutes && reader.CurrentTime.Seconds == reader.TotalTime.Seconds)
                {
                    next = true;
                }
            }
            if (stoppedEventArgs.Exception != null)
            {
                MessageBox.Show(stoppedEventArgs.Exception.Message, "Error Playing File");
            }
        }
    }
}
