using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoosterSysteem.Models
{
    public class Teacher
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string availableHours { get; set; }
        public string qualifiedCourse { get; set; }
        public string hourAvailability { get; set; }
        public string email { get; set; }
        public string note { get; set; }
    }
}