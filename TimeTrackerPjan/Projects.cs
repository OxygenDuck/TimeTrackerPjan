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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            lbxProjectsPjan.Items.Clear();
            foreach (Project project in MyApplicationContext.Projects)
            {
                lbxProjectsPjan.Items.Add(project.name);
            }
        }

        private void btnAddPjan_Click(object sender, EventArgs e)
        {
            foreach(Project project in MyApplicationContext.Projects)
            {
                if (project.name == tbxNamePjan.Text)
                {
                    MessageBox.Show("That project name already exists");
                    return;
                }
            }
            if (tbxNamePjan.Text == "")
            {
                MessageBox.Show("A Project name may not be blank");
                return;
            }
            Project newProject = new Project(tbxNamePjan.Text);
            MyApplicationContext.Projects.Add(newProject);
            UpdateList();
        }

        private void btnRenamePjan_Click(object sender, EventArgs e)
        {
            Project projectToRename = null;
            int selectedIndex;
            if (lbxProjectsPjan.SelectedIndex >= 0)
            {
                foreach (Project project in MyApplicationContext.Projects)
                {
                    if (project.name == tbxNamePjan.Text)
                    {
                        MessageBox.Show("That project name already exists");
                        return;
                    }

                    if (project.name == lbxProjectsPjan.SelectedItem.ToString())
                    {
                        projectToRename = project;
                    }
                }

                projectToRename.name = tbxNamePjan.Text;
                selectedIndex = lbxProjectsPjan.SelectedIndex;
                UpdateList();
                lbxProjectsPjan.SelectedIndex = selectedIndex;
            }
            else
            {
                MessageBox.Show("No Project has been selected to rename");
            }
        }

        private void btnDeletePjan_Click(object sender, EventArgs e)
        {
            if (lbxProjectsPjan.SelectedIndex >= 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this project?", "Hold Up", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    MyApplicationContext.Projects.RemoveAt(lbxProjectsPjan.SelectedIndex);
                    UpdateList();
                }
            }
            else
            {
                MessageBox.Show("No Project has been selected to delete");
            }
        }

        private void btnCategoriesPjan_Click(object sender, EventArgs e)
        {
            if (lbxProjectsPjan.SelectedIndex >= 0)
            {
                using (frmCategoriesPjan categoryManager = new frmCategoriesPjan(MyApplicationContext.Projects[lbxProjectsPjan.SelectedIndex]))
                {
                    DialogResult result = categoryManager.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No Project has been selected to manage");
            }
        }
    }
}
