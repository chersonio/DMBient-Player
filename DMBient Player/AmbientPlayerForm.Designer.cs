
namespace DMBient_Player
{
    partial class AmbientPlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmbientPlayerForm));
            this.togglePlay = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.containerPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.volumeScroll = new Bunifu.UI.WinForms.BunifuHSlider();
            ((System.ComponentModel.ISupportInitialize)(this.togglePlay)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // togglePlay
            // 
            this.togglePlay.AllowFocused = false;
            this.togglePlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.togglePlay.AutoSizeHeight = true;
            this.togglePlay.BorderRadius = 0;
            this.togglePlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togglePlay.Image = ((System.Drawing.Image)(resources.GetObject("togglePlay.Image")));
            this.togglePlay.IsCircle = true;
            this.togglePlay.Location = new System.Drawing.Point(12, 0);
            this.togglePlay.Name = "togglePlay";
            this.togglePlay.Size = new System.Drawing.Size(116, 116);
            this.togglePlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.togglePlay.TabIndex = 6;
            this.togglePlay.TabStop = false;
            this.togglePlay.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.togglePlay.Click += new System.EventHandler(this.togglePlay_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.containerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("containerPanel.BackgroundImage")));
            this.containerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.containerPanel.BorderColor = System.Drawing.Color.Transparent;
            this.containerPanel.BorderRadius = 3;
            this.containerPanel.BorderThickness = 1;
            this.containerPanel.Controls.Add(this.volumeScroll);
            this.containerPanel.Controls.Add(this.togglePlay);
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(3, 3, 72, 40);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.ShowBorders = true;
            this.containerPanel.Size = new System.Drawing.Size(140, 140);
            this.containerPanel.TabIndex = 6;
            // 
            // volumeScroll
            // 
            this.volumeScroll.AllowCursorChanges = true;
            this.volumeScroll.AllowHomeEndKeysDetection = false;
            this.volumeScroll.AllowIncrementalClickMoves = true;
            this.volumeScroll.AllowMouseDownEffects = false;
            this.volumeScroll.AllowMouseHoverEffects = false;
            this.volumeScroll.AllowScrollingAnimations = true;
            this.volumeScroll.AllowScrollKeysDetection = true;
            this.volumeScroll.AllowScrollOptionsMenu = true;
            this.volumeScroll.AllowShrinkingOnFocusLost = false;
            this.volumeScroll.BackColor = System.Drawing.Color.Transparent;
            this.volumeScroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volumeScroll.BackgroundImage")));
            this.volumeScroll.BindingContainer = null;
            this.volumeScroll.BorderRadius = 2;
            this.volumeScroll.BorderThickness = 1;
            this.volumeScroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeScroll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.volumeScroll.DrawThickBorder = false;
            this.volumeScroll.DurationBeforeShrink = 2000;
            this.volumeScroll.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.volumeScroll.LargeChange = 10;
            this.volumeScroll.Location = new System.Drawing.Point(0, 109);
            this.volumeScroll.Maximum = 100;
            this.volumeScroll.Minimum = 0;
            this.volumeScroll.MinimumSize = new System.Drawing.Size(0, 31);
            this.volumeScroll.MinimumThumbLength = 18;
            this.volumeScroll.Name = "volumeScroll";
            this.volumeScroll.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.volumeScroll.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.volumeScroll.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.volumeScroll.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.volumeScroll.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.volumeScroll.ShrinkSizeLimit = 3;
            this.volumeScroll.Size = new System.Drawing.Size(140, 31);
            this.volumeScroll.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(194)))), ((int)(((byte)(174)))));
            this.volumeScroll.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.volumeScroll.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.volumeScroll.SmallChange = 1;
            this.volumeScroll.TabIndex = 7;
            this.volumeScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.volumeScroll.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.volumeScroll.ThumbLength = 18;
            this.volumeScroll.ThumbMargin = 1;
            this.volumeScroll.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.volumeScroll.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.volumeScroll.Value = 0;
            this.volumeScroll.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.bunifuHSlider1_Scroll);
            // 
            // AmbientPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(140, 140);
            this.ControlBox = false;
            this.Controls.Add(this.containerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AmbientPlayerForm";
            ((System.ComponentModel.ISupportInitialize)(this.togglePlay)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox togglePlay;
        private Bunifu.UI.WinForms.BunifuPanel containerPanel;
        private Bunifu.UI.WinForms.BunifuHScrollBar volumeBar;
        private Bunifu.UI.WinForms.BunifuHSlider volumeScroll;
    }
}