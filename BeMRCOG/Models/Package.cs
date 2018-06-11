using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Models
{
    public class Package
    {
        public int ID { get; set; }
        public int ModuleCount { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; } 
    }
}