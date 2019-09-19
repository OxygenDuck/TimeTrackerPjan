﻿using System;
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
        static public System.Timers.Timer popupInterval;
        NotifyIcon _notifyIcon;
        static public List<Activity> Activities = new List<Activity>();
        static public List<Project> Projects = new List<Project>();
        static public int dismissCounter = 0;
        bool allowPopup = true;

        public MyApplicationContext()
        {
            _notifyIcon = new NotifyIcon();
            _notifyIcon.Icon = Properties.Resources.Icon;

            using (SplashScreen splashScreen = new SplashScreen())
            {
                DialogResult result = splashScreen.ShowDialog();
            }

            MenuItem ExitMenu = new MenuItem("Exit", new EventHandler(DoExit));
            MenuItem TrackMenu = new MenuItem("Track Me", new EventHandler(OpenPopup));
            MenuItem LogMenu = new MenuItem("Save Log", new EventHandler(SaveActivities));
            MenuItem ShowProjects = new MenuItem("Show Projects", new EventHandler(ShowProjectsForm));
            MenuItem ShowOptions = new MenuItem("Options", new EventHandler(ShowOptionsForm));
            ContextMenu cm = new ContextMenu(new MenuItem[] { TrackMenu, LogMenu, ShowProjects, ShowOptions, ExitMenu });

            _notifyIcon.ContextMenu = cm;
            _notifyIcon.Visible = true;

            LoadActivities();

            popupInterval = new System.Timers.Timer(Properties.Settings.Default.PopupInterval);
            popupInterval.Elapsed += TimerEnd;
            popupInterval.AutoReset = true;
            popupInterval.Enabled = true;
        }

        private void ShowOptionsForm(object sender, EventArgs e)
        {
            using (OptionsForm optionsForm = new OptionsForm())
            {
                DialogResult result = optionsForm.ShowDialog();
            }
        }

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

        private void ShowProjectsForm(object sender, EventArgs e)
        {
            popupInterval.Enabled = false;
            using (Projects ProjectsForm = new Projects())
            {
                DialogResult result = ProjectsForm.ShowDialog();
            }
            popupInterval.Enabled = true;
        }

        private void DoExit(object sender, EventArgs e)
        {
            _notifyIcon.Visible = false;
            Application.Exit();
        }

        private void SaveActivities(object sender, EventArgs e)
        {
            //json.net
            using (StreamWriter writeFile = new StreamWriter(@"C:\Users\Janssen\Desktop\timetrackertest\activities.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(writeFile, Activities);
            }
        }

        private void LoadActivities()
        {
            //json.net
            string reader = System.IO.File.ReadAllText(@"C:\Users\Janssen\Desktop\timetrackertest\activities.json");
            Activities = JsonConvert.DeserializeObject<List<Activity>>(reader);
        }
    }
}