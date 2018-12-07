using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoosterSysteem.Models
{
    public class Faculty
    {
        public string name { get; set; }
        public List<Teacher> listTeacher { get; set; }
        public List<Classroom> listClassroom { get; set; }
    }
}