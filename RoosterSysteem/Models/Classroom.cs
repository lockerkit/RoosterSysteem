using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoosterSysteem.Models
{
    public class Classroom
    {
        public string classroomNumber { get; set; }
        public int capacityClassroom { get; set; }
        public string typeClassroom { get; set; }
        public string linkedFaculty { get; set; }
    }
}