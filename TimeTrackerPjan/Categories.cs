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
        //Variables
        private Project project;

        //Constructor
        public frmCategoriesPjan(Project project)
        {
            InitializeComponent();
            this.project = project;
            lblProjectNamePjan.Text = project.name;
            lblHoursSpentPjan.Text = "";
            lblMinutesSpentPjan.Text = "";
            UpdateList();
        }

        //Update Listbox
        private void UpdateList()
        {
            lbxCategoriesPjan.Items.Clear();
            foreach(ProjectCategory category in project.Categories)
            {
                lbxCategoriesPjan.Items.Add(category.name);
            }
        }

        //Add Category
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
            Log.Write("Category added: '" + tbxNamePjan.Text + "'");
            UpdateList();
        }

        //Rename Category
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

                Log.Write("Renamed Category '" + categoryToRename.name + "' to '" + tbxNamePjan.Text + "'");
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

        //Delete Category
        private void btnDeletePjan_Click(object sender, EventArgs e)
        {
            if (lbxCategoriesPjan.SelectedIndex >= 0)
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to remove this category?", "Hold Up", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    Log.Write("Removed Category '" + project.Categories[lbxCategoriesPjan.SelectedIndex].name + "'");
                    project.Categories.RemoveAt(lbxCategoriesPjan.SelectedIndex);
                    UpdateList();
                }
            }
            else
            {
                MessageBox.Show("No Category has been selected to delete");
            }
        }

        //Save expected time
        private void btnSaveExpectedPjan_Click(object sender, EventArgs e)
        {
            if (lbxCategoriesPjan.SelectedIndex >= 0)
            {
                project.Categories[lbxCategoriesPjan.SelectedIndex].SetExpected(nudHoursExpPjan.Value, nudMinutesExpPjan.Value);
                Log.Write("Updated expected time for category '" + project.Categories[lbxCategoriesPjan.SelectedIndex].name + "'");
                MessageBox.Show("Expected time has been saved");
            }
            else
            {
                MessageBox.Show("No Category has been selected to set expected time");
            }
        }

        //Actions when a category is selected
        private void lbxCategoriesPjan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectCategory category = project.Categories[lbxCategoriesPjan.SelectedIndex];
            //Set the correct values for the expected time selector
            nudHoursExpPjan.Value = category.expHours;
            nudMinutesExpPjan.Value = category.expMinutes;

            //Get the spent time on the category
            List<Activity> activitiesInCategory = new List<Activity>();
            foreach (Activity activity in MyApplicationContext.Activities)
            {
                if (activity.projectIndex == project.index && activity.categoryIndex == category.index)
                {
                    activitiesInCategory.Add(activity);
                }
            }

            int spentHours = 0;
            int spentMinutes = 0;
            for (int i = activitiesInCategory.Count - 1; i > 0; i--)
            {
                //Check to make sure breaks between days arent counted
                //! if this is deemed too buggy, change it accordingly
                if (activitiesInCategory[i].timeslot.Date == activitiesInCategory[i - 1].timeslot.Date)
                {
                    TimeSpan timespan = activitiesInCategory[i].timeslot - activitiesInCategory[i - 1].timeslot;
                    spentHours += timespan.Hours;
                    spentMinutes += timespan.Minutes;
                }
            }
            lblHoursSpentPjan.Text = spentHours.ToString();
            lblMinutesSpentPjan.Text = spentMinutes.ToString();

            //Get the difference between planned and actual time
            int hoursDifference = spentHours - Convert.ToInt32(category.expHours);
            int minutesDifference = spentMinutes - Convert.ToInt32(category.expMinutes);

            if (hoursDifference > 0)
            {
                lblHoursDifPjan.Text = "+" + hoursDifference.ToString();
            }
            else
            {
                lblHoursDifPjan.Text = hoursDifference.ToString();
            }

            if (minutesDifference > 0)
            {
                lblMinutesDifPjan.Text = "+" + minutesDifference.ToString();
            }
            else
            {
                lblMinutesDifPjan.Text = minutesDifference.ToString();
            }
        }
    }
}
