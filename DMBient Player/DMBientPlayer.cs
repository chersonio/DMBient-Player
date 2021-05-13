using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using static DMBient_Player.Manager;
using System.Timers;
using System.Threading.Tasks;

namespace DMBient_Player
{
    public partial class DMBientPlayer : Form
    {

        public WMPLib.WindowsMediaPlayer winMediaPlayer = new WMPLib.WindowsMediaPlayer();

        //Ta delegates xrisimevoun gia na exeis prosvasi se methodous otan kanonika "apagoreuetai" logw Cross Thread Operations.
        private delegate void PanelSafeCallDelegate(Control control);
        private PanelSafeCallDelegate callDelegate = new PanelSafeCallDelegate((control) => { control.Show(); });
        private PanelSafeCallDelegate blueBackgroundDelegate = new PanelSafeCallDelegate((control) => { control.BackColor = Color.Blue; });

        public Customize customizeForm = new Customize();
        public QuickAccess quickAccessForm = new QuickAccess();
        public Controls controlsForm = new Controls();

        public DMBientPlayer()
        {
            InitializeComponent();

            foreach (Scenario scenario in Settings.Scenarios)
            {
                quickAccessForm.Controls.Add(new ScenarioPanelForm(scenario) { Location = new Point(438, 173) });
            }
            quickAccessForm.Controls[0].Show();

            mainProgramPanel.Controls.Add(quickAccessForm);
            mainProgramPanel.Controls.Add(customizeForm);
            mainProgramPanel.Controls.Add(controlsForm);

            quickAccessForm.Show();

            Settings.selectedTheme = Theme.AlloKirileOnomaGiaTheme;
            switch (Settings.selectedTheme)
            {
                case Theme.KirileOnomaGiaTheme:
                    break;
                case Theme.AlloKirileOnomaGiaTheme:
                    break;
                case Theme.BloodRoses:
                    break;
                default:
                    break;
            }

            //*** set icons prepei na ginei mesa sti FOREACH ***
            //den mporw na parw tin timi tou ambientButton kai na ti settarw san iconidio.
            // epeita na tin allazw me to eventClick apo play i pause
            //if (ambientButton.Icon.Contains("bar"))

            //    ambientButton.Icon = CofigurationManager "IconsFilePath" + @"\Icons\voice_recognition_100px.png";
            //else ambientButton.Icon = @"C:\Users\chers\Desktop\C# homework\DMbience\Icons\pause_100px.png";

            //afthaireta pairnoume ena prwto senario
            //***prosoxi
            //ifs edw kai error handling gia periptwseis kai gia settings

            //Testing for TIMERS

            //winMediaPlayer.settings.volume = 50;
            //winMediaPlayer.URL = @"E:\01 Music\01 Tango\02 Tandas\epiloges 2019\TANGO Tango Bardo (Negarcha) +1\04 Negracha.mp3";
            //double trackDuration = winMediaPlayer.currentMedia.duration;
            //winMediaPlayer.controls.currentPosition = 170; // swsto. ksekinaei apo to 25 deuterolepto
            //winMediaPlayer.controls.currentPositionString = 25; // swsto. ksekinaei apo to 25 deuterolepto

            //winMediaPlayer.controls.play();
        }

        //private void Atimer_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    winMediaPlayer.settings.volume += (winMediaPlayer.settings.volume<100)? 1:0;//ama eisai mortis
        //    Console.WriteLine(winMediaPlayer.controls.currentPosition.ToString()); //0
        //    //bunifuTextBox2.Text = winMediaPlayer.controls.currentPosition.ToString(); //25
        //}


        private void btnQuickAccess_Click(object sender, EventArgs e)
        {
            indicator.Top = btnQuickAccess.Top + 13;
            quickAccessForm.Show();
            customizeForm.Hide();
            controlsForm.Hide();
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            indicator.Top = btnCustomize.Top + 13;
            quickAccessForm.Hide();
            customizeForm.Show();
            controlsForm.Hide();
        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            indicator.Top = btnControls.Top + 13;
            quickAccessForm.Hide();
            customizeForm.Hide();
            controlsForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Task task = new Task(() =>
            {
                foreach (Control button in mainProgramPanel.Controls[0].Controls[0].Controls)
                this.Invoke(blueBackgroundDelegate, new object[] { button });
            });
            task.Start();

            DMBShouts dmbShouts = new DMBShouts();
            dmbShouts.Task();
        }

        //easy to navigate readme page. MAKE IT***
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //change panel and Load the Tutorial text
            //This will need links to go to top for easy access
        }

        private void masterPlayPausePnl_Click(object sender, EventArgs e)
        {

        }
    }
}
