using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    public class Enrollments
    {
        public int CourseId { get; set; }
        public Courses Course { get; set; }
        public int StudentId { get; set; }
        public Students Student { get; set; }

        public DateTime EnrollDate { get; set; }
    }
}
