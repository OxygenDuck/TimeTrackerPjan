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
    public partial class frmCategoriesPjan : Form
    {
        private Project project;

        public frmCategoriesPjan(Project project)
        {
            InitializeComponent();
            this.project = project;
            lblProjectNamePjan.Text = project.name;
            UpdateList();
        }

        private void UpdateList()
        {
            lbxCategoriesPjan.Items.Clear();
            foreach(ProjectCategory category in project.Categories)
            {
                lbxCategoriesPjan.Items.Add(category.name);
            }
        }

        private void btnAddPjan_Click(object sender, EventArgs e)
        {
            foreach (ProjectCategory category in project.Categories)
            {
                if (category.name == tbxNamePjan.Text)
                {
                    MessageBox.Show("That Category name already exists");
                    return;
                }
            }
            if (tbxNamePjan.Text == "")
            {
                MessageBox.Show("A Category name may not be blank");
                return;
            }
            ProjectCategory newCategory = new ProjectCategory(tbxNamePjan.Text, project);
            project.Categories.Add(newCategory);
            UpdateList();
        }

        private void btnRenamePjan_Click(object sender, EventArgs e)
        {
            ProjectCategory categoryToRename = null;
            int selectedIndex;
            if (lbxCategoriesPjan.SelectedIndex >= 0)
            {
                foreach (ProjectCategory category in project.Categories)
                {
                    if (category.name == tbxNamePjan.Text)
                    {
                        MessageBox.Show("That Category name already exists");
                        return;
                    }

                    if (category.name == lbxCategoriesPjan.SelectedItem.ToString())
                    {
                        categoryToRename = category;
                    }
                }

                categoryToRename.name = tbxNamePjan.Text;
                selectedIndex = lbxCategoriesPjan.SelectedIndex;
                UpdateList();
                lbxCategoriesPjan.SelectedIndex = selectedIndex;
            }
            else
            {
                MessageBox.Show("No Project has been selected to rename");
            }
        }

        private void btnDeletePjan_Click(object sender, EventArgs e)
        {
            if (lbxCategoriesPjan.SelectedIndex >= 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this category?", "Hold Up", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    project.Categories.RemoveAt(lbxCategoriesPjan.SelectedIndex);
                    UpdateList();
                }
            }
            else
            {
                MessageBox.Show("No Category has been selected to delete");
            }
        }
    }
}
