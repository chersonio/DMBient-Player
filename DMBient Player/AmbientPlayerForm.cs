using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace DMBient_Player
{
    public partial class AmbientPlayerForm : Form
    {
        public WMPLib.WindowsMediaPlayer winMediaPlayer = new WMPLib.WindowsMediaPlayer();

        public string FileName { get; set; } = "";

        private System.Timers.Timer TrackTimer = new System.Timers.Timer();
        private bool Repeat { get; set; } = false;// time intervals- every 5 seconds the sound will be played
        private double Start { get; set; } = 0; // this will declare the begining of a sound
        private double Finish { get; set; } = 0; // this will declare the end of a sound. 
        private double FadeIn { get; set; } = 0; // this will declare the begining of volume increase
        private double FadeOut { get; set; } = 0; // this will declare the begining of volume decrease

        public AmbientPlayerForm(AmbientButton ambientButton)
        {
            InitializeComponent();
            TopLevel = false;

            winMediaPlayer.settings.autoStart = false;
            //Set volumes
            winMediaPlayer.settings.volume = ambientButton.Volume;
            volumeScroll.Value = ambientButton.Volume;

            Repeat = ambientButton.Repeat;
            Start = ambientButton.Start;
            Finish = ambientButton.Finish;
            FadeIn = ambientButton.FadeIn;
            FadeOut = ambientButton.FadeOut;

            FileName = ambientButton.FilePath;
            winMediaPlayer.URL = this.FileName;

            if (ambientButton.Finish == 0)
            {
                ambientButton.Finish = winMediaPlayer.currentMedia.duration;
            }

            //winMediaPlayer.controls.play();
            winMediaPlayer.controls.currentPosition = 120;

            //testing about timers

            TrackTimer.Interval = 50; //milisecond
            TrackTimer.AutoReset = true;
            TrackTimer.Enabled = false;
            TrackTimer.Elapsed += TrackTimer_Elapsed;
        }

        private void TrackTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                double currentPosition = winMediaPlayer.controls.currentPosition;

                //de prepei na baloume kai to max simeio tou kommatiou?
                //duration fix tou fade sta 2-3 seconds
                //proteinw gia pososto metavolis

                // me to current position kathorizeis to pote. boithaei stin afairesi
                // me to fadein-out se boithaei na ksereis pote ksekinaei-teleiwnei metaksi twn prokathorizmenwn 3 sec
                // to duration sou leei mexri pote mporei na elegxei.

                int duration;
                int fadeIn; // de mporw na parw ti timi tou sygkekrimenou ambientButton
                int fadeOut; // de mporw na parw ti timi tou sygkekrimenou ambientButton

                //fadein prwta

                //if (fadeIn + 3 <= duration && fadeIn >= 0 && fadeOut + 3 <= duration && fadeOut >= 0) 
                //{
                //    if (fadeIn == currentPosition && fadeIn < fadeOut) { }
                //    if (fadeOut == currentPosition && fadeOut < fadeIn) { }
                //}
            }
            catch
            { }
        }

        private void scrollBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {
            winMediaPlayer.settings.volume = e.Value;
            if (winMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                winMediaPlayer.controls.play();
            }
        }

        private void togglePlay_Click(object sender, EventArgs e)
        {
            //winMediaPlayer.settings.volume = e.Value;
            //if (winMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    winMediaPlayer.controls.play();
            //}


            if (winMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                winMediaPlayer.controls.play();
                TrackTimer.Enabled = true;

                //togglePlay.Image = System.Drawing.Image.FromFile(@"C:\Users\chers\Desktop\C# homework\DMbience\Icons\play_100px.png");
            }
            else
            {
                TrackTimer.Enabled = false;
                winMediaPlayer.controls.pause();
                //togglePlay.Image = System.Drawing.Image.FromFile(@"C:\Users\chers\Desktop\C# homework\DMbience\Icons\pause_100px.png");
            }
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            winMediaPlayer.settings.volume = e.Value;
            if (winMediaPlayer.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                winMediaPlayer.controls.play();
            }
        }
    }
}
