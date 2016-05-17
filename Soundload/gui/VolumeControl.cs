using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using System.Diagnostics;
using NAudio.CoreAudioApi.Interfaces;
using System.Media;

//Credits to NAudioDemo/VolumeMixerDemo:    https://github.com/naudio/NAudio/blob/master/NAudioDemo/VolumeMixerDemo/VolumePanel.cs
namespace SoundCloudDownloader
{
    public partial class VolumeControl : Form
    {
        private MMDevice device;
     
        public VolumeControl()
        {
            InitializeComponent();
            MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();
            device = deviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            tbVolume.Value = (int)(Math.Round(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100));

            if (device.AudioEndpointVolume.Mute)
            {
                btnMuteUnmute.Image = Properties.Resources.Mute;
            } 
        }

       
        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = tbVolume.Value / 100.0f;
            if (device.AudioEndpointVolume.Mute)
            {
                device.AudioEndpointVolume.Mute = false;
                btnMuteUnmute.Image = Properties.Resources.Volume;
            }
            btnMuteUnmute.Image = Properties.Resources.Volume;
        }

       
        private void btnMuteUnmute_Click(object sender, EventArgs e)
        {
            if (device.AudioEndpointVolume.Mute)
            {
                device.AudioEndpointVolume.Mute = false;
                btnMuteUnmute.Image = Properties.Resources.Volume;
            }
            else
            {
                device.AudioEndpointVolume.Mute = true;
                btnMuteUnmute.Image = Properties.Resources.Mute;
            }
        }

        private void VolumeControl_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
