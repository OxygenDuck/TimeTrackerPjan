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
    public partial class OptionsForm : Form
    {
        //Constructor
        public OptionsForm()
        {
            InitializeComponent();

            //Show the current values
            nudIntervalPjan.Value = Properties.Settings.Default.PopupInterval / 60000;
        }

        //Reset values to default
        private void btnResetPjan_Click(object sender, EventArgs e)
        {
            Log.Write("Reset default settings");
            nudIntervalPjan.Value = 30;
        }

        //Save Settings
        private void btnSavePjan_Click(object sender, EventArgs e)
        {
            Log.Write("Saving settings");
            int popupInterval = ConvertInterval(nudIntervalPjan.Value);
            MyApplicationContext.popupInterval.Interval = popupInterval;
            Properties.Settings.Default.PopupInterval = popupInterval;

            this.DialogResult = DialogResult.OK;
        }

        //Convert time form minutes to ms
        private int ConvertInterval(decimal interval)
        {
            interval *= 60; //minutes to seconds
            interval *= 1000; //seconds to ms
            return Convert.ToInt32(interval);
        }

        private void btnSaveLogPjan_Click(object sender, EventArgs e)
        {
            Log.Write("Saving log");
            Log.Save();
        }
    }
}
