using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bai3.Models
{
    public class Studenter
    {
        [Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollmenter> Enrollments { get; set; }
    }
}
