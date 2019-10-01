using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TimeTrackerPjan
{
    public class MyApplicationContext : ApplicationContext
    {
        //Variables, Lists and Onjects
        static public System.Timers.Timer popupInterval;
        NotifyIcon _notifyIcon;
        static public List<Activity> Activities = new List<Activity>();
        static public List<Project> Projects = new List<Project>();
        static public int dismissCounter = 0;
        bool allowPopup = true;

        //Constructor and Initialization
        public MyApplicationContext()
        {
            //Set icon
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Icon = Properties.Resources.Icon;

            //Show splashscreen
            using (SplashScreen splashScreen = new SplashScreen())
            {
                DialogResult result = splashScreen.ShowDialog();
            }

            //Set the traymenu
            MenuItem ExitMenu = new MenuItem("Exit", new EventHandler(DoExit));
            MenuItem TrackMenu = new MenuItem("Track Me", new EventHandler(OpenPopup));
            MenuItem LogMenu = new MenuItem("Save Log", new EventHandler(SaveActivities));
            MenuItem ShowProjects = new MenuItem("Show Projects", new EventHandler(ShowProjectsForm));
            MenuItem ShowOptions = new MenuItem("Options", new EventHandler(ShowOptionsForm));
            ContextMenu cm = new ContextMenu(new MenuItem[] { TrackMenu, LogMenu, ShowProjects, ShowOptions, ExitMenu });

            _notifyIcon.ContextMenu = cm;
            _notifyIcon.Visible = true;

            //Load previous activities
            if (Properties.Settings.Default.LatestSave != "")
            {
                LoadActivities(Properties.Settings.Default.LatestSave);
            }
            else
            {
                DialogResult result = MessageBox.Show("You don't seem to have a previous log, would you like to open one?", "No log found", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "CSV | *.csv";
                        DialogResult dialogResult = openFileDialog.ShowDialog();
                        if (dialogResult == DialogResult.OK)
                        {
                            LoadActivities(openFileDialog.FileName);
                            Properties.Settings.Default.LatestSave = openFileDialog.FileName;
                        }
                    }
                }
            }
            

            //Set timer settings
            popupInterval = new System.Timers.Timer(Properties.Settings.Default.PopupInterval);
            popupInterval.Elapsed += TimerEnd;
            popupInterval.AutoReset = true;
            popupInterval.Enabled = true;
        }

        //Show options
        private void ShowOptionsForm(object sender, EventArgs e)
        {
            using (OptionsForm optionsForm = new OptionsForm())
            {
                DialogResult result = optionsForm.ShowDialog();
            }
        }

        //Actions at timer end
        private void TimerEnd(object sender, EventArgs e)
        {
            if (dismissCounter > 0)
            {
                dismissCounter--;
            }
            else
            {
                OpenPopup(null, null);
            }
        }

        //Open timetracker popup
        private void OpenPopup(object sender, EventArgs e)
        {
            if (allowPopup)
            {
                allowPopup = false;
                using (frmPopupPjan Popup = new frmPopupPjan())
                {
                    DialogResult result = Popup.ShowDialog();
                    allowPopup = true;
                    //TODO: Set focus to popup window (should)
                }
            }
        }

        //Show projects
        private void ShowProjectsForm(object sender, EventArgs e)
        {
            popupInterval.Enabled = false;
            using (Projects ProjectsForm = new Projects())
            {
                DialogResult result = ProjectsForm.ShowDialog();
            }
            popupInterval.Enabled = true;
        }

        //Exit application
        private void DoExit(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            Application.Exit();
        }

        //Save Projects & Activities to csv
        private void SaveActivities(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV | *.csv"; ;
                DialogResult result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();

                    csv.AppendLine("Projects");
                    //Write all projects
                    foreach (Project project in Projects)
                    {
                        csv.AppendLine("p," + project.index.ToString() + "," + project.name);
                        foreach (ProjectCategory category in project.Categories)
                        {
                            string cIndex = category.index.ToString(), cName = category.name;
                            string cHours = category.expHours.ToString(), cMinutes = category.expMinutes.ToString();
                            csv.AppendLine(string.Format("c,{0},{1},{2},{3}",cIndex, cName, cHours, cMinutes));
                        }
                    }

                    //Write all activities
                    csv.AppendLine("Activities");
                    foreach (Activity activity in Activities)
                    {
                        //Get all the data in an activity
                        string time = activity.timeslot.ToString();
                        string project = GetProjectFromId(activity.projectIndex);
                        string projectCategory = GetCategoryFromId(project, activity.categoryIndex);
                        string name = activity.name;
                        string details = activity.details;

                        //write to csv file
                        string newline = string.Format("{0},{1},{2},{3},{4}", time, project, projectCategory, name, details);
                        csv.AppendLine(newline);
                    }
                    File.WriteAllText(saveFileDialog.FileName, csv.ToString());
                    Properties.Settings.Default.LatestSave = saveFileDialog.FileName;
                }
            }
        }

        //Get project name
        private string GetProjectFromId(int Id)
        {
            if (Id == -1)
            {
                return "";
            }
            else
            {
                foreach (var project in Projects)
                {
                    if (project.index == Id)
                    {
                        return project.name;
                    }
                }
            }
            return "";
        }

        //get category name
        private string GetCategoryFromId(string projectName, int Id)
        {
            Project selectedProject = null;
            if (Id == -1)
            {
                return "";
            }
            else
            {
                foreach (var project in Projects)
                {
                    if (project.name == projectName)
                    {
                        selectedProject = project;
                    }
                }
            }
            if (selectedProject != null)
            {
                foreach (var category in selectedProject.Categories)
                {
                    if (category.index == Id)
                    {
                        return category.name;
                    }
                }
            }
            return "";
        }

        //Load Activities
        private void LoadActivities(string FilePath)
        {
            Projects.Clear();

            Project newProject = null;
            int newProjectIndex = 0;
            bool writeActivities = false;
            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');

                    if (!writeActivities)
                    {
                        switch (values[0])
                        {
                            case "Projects": writeActivities = false; break; //start writing projects
                            case "p":
                                //Add project
                                //Index, Name
                                newProject = new Project(Convert.ToInt32(values[1]), values[2]);
                                Projects.Add(newProject);
                                newProjectIndex = Projects.IndexOf(newProject); break;
                            case "c":
                                //Add category to project
                                //Index, Name, Hours, Minutes
                                Projects[newProjectIndex].Categories.Add(new ProjectCategory(Convert.ToInt32(values[1]), values[2], Convert.ToDecimal(values[3]) , Convert.ToDecimal(values[4]))); break;
                            case "Activities": writeActivities = true; break; //start writing activities
                        }
                    }
                    else
                    {
                        //Add activity
                        //Date & time, Project, Category, Name, Details
                        Activities.Add(new Activity(DateTime.Parse(values[0]), values[1], values[2], values[3], values[4]));
                    }
                }
            }
        }
    }
}
