using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int ModuleCount { get; set; }

        public List<Module> Modules { get; set; }
        public List<Package> Packages { get; set; }

        public Course()
        {
            Modules = new List<Module>();
            Packages = new List<Package>();
        }
    }
}