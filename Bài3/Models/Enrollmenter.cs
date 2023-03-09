using System.ComponentModel.DataAnnotations;

namespace Bai3.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollmenter
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Coursera Course { get; set; }
        public Studenter Student { get; set; }
    }
}
