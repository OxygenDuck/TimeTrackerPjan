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
        public OptionsForm()
        {
            InitializeComponent();

            //Show the current values
            nudIntervalPjan.Value = Properties.Settings.Default.PopupInterval / 60000;
        }

        private void btnResetPjan_Click(object sender, EventArgs e)
        {
            nudIntervalPjan.Value = 30;
        }

        private void btnSavePjan_Click(object sender, EventArgs e)
        {
            int popupInterval = ConvertInterval(nudIntervalPjan.Value);
            MyApplicationContext.popupInterval.Interval = popupInterval;
            Properties.Settings.Default.PopupInterval = popupInterval;

            this.DialogResult = DialogResult.OK;
        }

        private int ConvertInterval(decimal interval)
        {
            interval *= 60; //minutes to seconds
            interval *= 1000; //seconds to ms
            return Convert.ToInt32(interval);
        }
    }
}
