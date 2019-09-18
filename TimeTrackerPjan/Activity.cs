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
        public string projectName;
        public string categoryName;

        public Activity(string Name, string Details, string ProjectName = "", string CategoryName = "")
        {
            name = Name;
            details = Details;
            timeslot = DateTime.Now;
            projectName = ProjectName;
            categoryName = CategoryName;
        }
    }
}
