
namespace DMBient_Player
{
    partial class ScenarioPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScenarioPanelForm));
            this.ScenarioPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SuspendLayout();
            // 
            // ScenarioPanel
            // 
            this.ScenarioPanel.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.ScenarioPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScenarioPanel.BackgroundImage")));
            this.ScenarioPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScenarioPanel.BorderColor = System.Drawing.Color.AliceBlue;
            this.ScenarioPanel.BorderRadius = 3;
            this.ScenarioPanel.BorderThickness = 1;
            this.ScenarioPanel.Location = new System.Drawing.Point(-8, -8);
            this.ScenarioPanel.Name = "ScenarioPanel";
            this.ScenarioPanel.Padding = new System.Windows.Forms.Padding(72, 40, 0, 0);
            this.ScenarioPanel.ShowBorders = false;
            this.ScenarioPanel.Size = new System.Drawing.Size(920, 540);
            this.ScenarioPanel.TabIndex = 3;
            // 
            // ScenarioPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(904, 524);
            this.ControlBox = false;
            this.Controls.Add(this.ScenarioPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScenarioPanelForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel ScenarioPanel;
    }
}