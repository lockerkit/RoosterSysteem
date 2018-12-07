using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoosterSysteem.Models
{
    public class Course
    {
        public string courseName { get; set; }
        public string linkedEducation { get; set; }
        public int hoursWorkLecture { get; set; }
        public string hoursDiscussionLecture { get; set; }
        public int hoursLecture { get; set; }

    }
}