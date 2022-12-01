using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01.Entities
{
    public class Courses
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Precision(18,2)]
        public decimal Fees { get; set; }
        public int DurationInHours { get; set; }

        public List<Enrollments> EnrollmentCourses { get; set; }
    }
}
