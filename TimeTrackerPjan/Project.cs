using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerPjan
{
    public class Project
    {
        public string name;
        public List<ProjectCategory> Categories = new List<ProjectCategory>();
        public int index {get;}
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
    }

    public class ProjectCategory
    {
        public string name;
        public int index { get; }
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
    }
}
