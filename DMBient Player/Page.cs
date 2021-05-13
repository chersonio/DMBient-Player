using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMBient_Player
{
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
            TopLevel = false;
            Location = new Point(0, 0);
            Visible = false;
            BackColor = Color.AliceBlue;
            Size = new Size(1375, 57);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
