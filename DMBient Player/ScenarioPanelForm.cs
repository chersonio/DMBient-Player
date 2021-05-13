using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static DMBient_Player.Manager;

namespace DMBient_Player
{
    public partial class ScenarioPanelForm : Form
    {
        public ScenarioPanelForm(Scenario scenario)
        {
            InitializeComponent();
            TopLevel = false;
            
            List<Point> points = new List<Point>();
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    points.Add(new Point(x * 212, y * 180));
                }
            }

            int cnt = 0;

            foreach (AmbientButton button in scenario.Buttons)
            {
                ScenarioPanel.Controls.Add(new AmbientPlayerForm(button) { Location = points[cnt++] } );
            }

            SettingsManager.Save(Settings);

            foreach (AmbientPlayerForm ambientPlayerButton in ScenarioPanel.Controls)
            {
                ambientPlayerButton.Show(); 
            }
        }
    }
}

