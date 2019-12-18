using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class ProjectModel
    {

        public string Name { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public bool Complete { get; set; }
        public double Version { get; set; }

    }
}