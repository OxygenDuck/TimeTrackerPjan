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
        //Constructor
        public frmPopupPjan()
        {
            InitializeComponent();
            foreach (Project project in MyApplicationContext.Projects)
            {
                cbxProjectsPjan.Items.Add(project.name);
            }
            MyApplicationContext.dismissCounter = 0;
        }

        //Save activity
        private void btnSavePjan_Click(object sender, EventArgs e)
        {
            Activity newActivity = null;

            if (cbxProjectsPjan.SelectedIndex >= 0)
            {
                //get the selected project
                Project selectedProject = null;
                foreach (Project project in MyApplicationContext.Projects)
                {
                    if (project.name == cbxProjectsPjan.SelectedItem.ToString())
                    {
                        selectedProject = project;
                        break;
                    }
                }
            
                if (cbxCategoryPjan.SelectedIndex >= 0)
                {
                    //get the selected category
                    ProjectCategory selectedCategory = null;
                    foreach (ProjectCategory category in selectedProject.Categories)
                    {
                        if (category.name == cbxCategoryPjan.SelectedItem.ToString())
                        {
                            selectedCategory = category;
                            break;
                        }
                    }

                    newActivity = new Activity(tbxActivityPjan.Text, rtbDetailsPjan.Text, selectedProject.index, selectedCategory.index);
                }
                else
                {
                    newActivity = new Activity(tbxActivityPjan.Text, rtbDetailsPjan.Text, selectedProject.index);
                }
            }
            else
            {
                newActivity = new Activity(tbxActivityPjan.Text, rtbDetailsPjan.Text);
            }
            
            MyApplicationContext.Activities.Add(newActivity);
            this.DialogResult = DialogResult.OK;
        }

        //Dismiss popup
        private void btnDismissPjan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //Repeat last activity
        private void btnRepeatPjan_Click(object sender, EventArgs e)
        {
            if (MyApplicationContext.Activities.Count > 0)
            {
                Activity last = MyApplicationContext.Activities.Last();
                Activity newActivity = new Activity(last.name, last.details, last.projectIndex, last.categoryIndex);
                MyApplicationContext.Activities.Add(newActivity);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("You haven't submitted an activity to repeat yet");
            }
        }

        //Dismiss multiple
        private void btnDismissMultiplePjan_Click(object sender, EventArgs e)
        {
            MyApplicationContext.dismissCounter = Convert.ToInt32(nudDismissCounterPjan.Value);
            this.DialogResult = DialogResult.Cancel;
        }

        //Select project
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

        //Filter projects
        private void tbxFilterProjectsPjan_TextChanged(object sender, EventArgs e)
        {
            string filter = tbxFilterProjectsPjan.Text.ToLower();
            cbxProjectsPjan.Items.Clear();
            foreach (Project project in MyApplicationContext.Projects)
            {
                if (project.name.ToLower().Contains(filter))
                {
                    cbxProjectsPjan.Items.Add(project.name);
                }
            }
        }

        //Filter categories
        private void tbxFilterCategoriesPjan_TextChanged(object sender, EventArgs e)
        {
            string filter = tbxFilterCategoriesPjan.Text.ToLower();
            cbxCategoryPjan.Items.Clear();
            Project UsedProject = null;

            foreach (Project project in MyApplicationContext.Projects)
            {
                if (project.name == cbxProjectsPjan.Text)
                {
                    UsedProject = project;
                    break;
                }
            }

            foreach (ProjectCategory category in UsedProject.Categories)
            {
                if (category.name.ToLower().Contains(filter))
                {
                    cbxCategoryPjan.Items.Add(category.name);
                }
            }
        }
    }
}
