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
    public partial class frmPopupPjan : Form
    {
        public frmPopupPjan()
        {
            InitializeComponent();
            foreach (Project project in MyApplicationContext.Projects)
            {
                cbxProjectsPjan.Items.Add(project.name);
            }
            MyApplicationContext.dismissCounter = 0;
            this.BringToFront();
        }

        private void btnSavePjan_Click(object sender, EventArgs e)
        {
            Activity newActivity = null;

            if (cbxProjectsPjan.SelectedIndex >= 0)
            {
                if (cbxCategoryPjan.SelectedIndex >= 0)
                {
                    newActivity = new Activity(tbxActivityPjan.Text, rtbDetailsPjan.Text, cbxProjectsPjan.SelectedItem.ToString(), cbxCategoryPjan.SelectedItem.ToString());
                }
                else
                {
                    newActivity = new Activity(tbxActivityPjan.Text, rtbDetailsPjan.Text, cbxProjectsPjan.SelectedItem.ToString());
                }
            }
            else
            {
                newActivity = new Activity(tbxActivityPjan.Text, rtbDetailsPjan.Text);
            }
            
            MyApplicationContext.Activities.Add(newActivity);
            this.DialogResult = DialogResult.OK;
        }

        private void btnDismissPjan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRepeatPjan_Click(object sender, EventArgs e)
        {
            if (MyApplicationContext.Activities.Count > 0)
            {
                Activity last = MyApplicationContext.Activities.Last();
                Activity newActivity = new Activity(last.name, last.details, last.projectName, last.categoryName);
                MyApplicationContext.Activities.Add(newActivity);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You haven't submitted an activity to repeat yet");
            }
        }

        private void btnDismissMultiplePjan_Click(object sender, EventArgs e)
        {
            MyApplicationContext.dismissCounter = Convert.ToInt32(nudDismissCounterPjan.Value);
            this.DialogResult = DialogResult.Cancel;
        }

        private void cbxProjectsPjan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project selectedProject = null;
            foreach (Project project in MyApplicationContext.Projects)
            {
                if (project.name == cbxProjectsPjan.SelectedItem.ToString())
                {
                    selectedProject = project;
                    break;
                }
            }

            cbxCategoryPjan.SelectedIndex = -1;
            cbxCategoryPjan.Items.Clear();
            foreach (ProjectCategory category in selectedProject.Categories)
            {
                cbxCategoryPjan.Items.Add(category.name);
            }
        }
    }
}
