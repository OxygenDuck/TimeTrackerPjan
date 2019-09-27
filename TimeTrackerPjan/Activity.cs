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
    }
}
