using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackerPjan
{
    public class Activity
    {
        public string name;
        public string details;
        public DateTime timeslot;
        public int projectIndex;
        public int categoryIndex;

        //Constructor
        public Activity(string Name, string Details, int ProjectIndex = -1, int CategoryIndex = -1)
        {
            name = Name;
            details = Details;
            timeslot = DateTime.Now;
            projectIndex = ProjectIndex;
            categoryIndex = CategoryIndex;
        }

        //Constructor from Load
        public Activity(DateTime Datetime, string ProjectName, string CategoryName, string Name, string Details)
        {
            //Set timeslot
            timeslot = Datetime;

            //Get Project
            int arrayIndex = -1;
            projectIndex = -1;
            foreach (Project project in MyApplicationContext.Projects)
            {
                if (project.name == ProjectName)
                {
                    projectIndex = project.index;
                    arrayIndex = MyApplicationContext.Projects.IndexOf(project);
                    break;
                }
            }
            if (projectIndex == -1)
            {
                throw new Exception("There is no project with the name " + ProjectName);
            }

            //Get Category
            categoryIndex = -1;
            foreach (ProjectCategory category in MyApplicationContext.Projects[arrayIndex].Categories)
            {
                if (category.name == CategoryName)
                {
                    categoryIndex = category.index;
                    break;
                }
            }
            if (categoryIndex == -1)
            {
                throw new Exception("There is no category with the name " + CategoryName);
            }

            //Set Name and Details
            name = Name;
            details = Details;
        }
    }
}
