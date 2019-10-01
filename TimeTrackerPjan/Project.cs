using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerPjan
{
    public class Project
    {
        //variables
        public string name;
        public List<ProjectCategory> Categories = new List<ProjectCategory>();
        public int index {get;}

        //Constructor
        public Project(string Name)
        {
            name = Name;

            //Make unique index
            int newIndex = 0;
            bool con = true;
            while (con)
            {
                newIndex = new Random().Next(3000000);
                con = false;
                foreach (Project project in MyApplicationContext.Projects)
                {
                    if (newIndex == project.index)
                    {
                        con = true;
                    }
                }
            }
            index = newIndex;
        }

        //Load Constructor !Only use from load function!
        public Project(int Index, string Name)
        {
            index = Index;
            name = Name;
        }
    }

    //Category Class
    public class ProjectCategory
    {
        //Variables
        public string name;
        public int index { get; }
        public decimal expHours = 0, expMinutes = 0; //Expected hours and minutes

        //Constructor
        public ProjectCategory(string Name, Project project)
        {
            name = Name;

            //Make unique index
            int newIndex = 0;
            bool con = true;
            while (con)
            {
                newIndex = new Random().Next(3000000);
                con = false;
                foreach (ProjectCategory category in project.Categories)
                {
                    if (newIndex == category.index)
                    {
                        con = true;
                    }
                }
            }
            index = newIndex;
        }

        //Load Constructor !Only use form Load function!
        public ProjectCategory(int Index, string Name, decimal Hours, decimal Minutes)
        {
            index = Index;
            name = Name;
            expHours = Hours;
            expMinutes = Minutes;
        }

        //Set expected time
        public void SetExpected(decimal hours, decimal minutes)
        {
            expHours = hours;
            expMinutes = minutes;
        }
    }
}
