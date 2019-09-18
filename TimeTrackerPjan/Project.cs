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
        public Project(string Name)
        {
            name = Name;
        }
    }

    public class ProjectCategory
    {
        public string name;
        public ProjectCategory(string Name)
        {
            name = Name;
        }
    }
}
