using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerPjan
{
    public partial class SplashScreen : Form
    {
        //Constructor
        public SplashScreen()
        {
            InitializeComponent();
            lblVersionPjan.Text = "Version " + Program.Version.ToString();
        }

        //Exit splashscreen
        private void tmrDissapearPjan_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
