
using Bai3.Models;
using System;
using System.Linq;

namespace Bai3.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataLabBai3 context)
        {
            // Look for any students.
            if (context.Studenters.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Studenter[]
            {
                new Studenter{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Studenter{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Studenter{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Studenter{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Studenter{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Studenter{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Studenter{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Studenter{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Studenters.AddRange(students);
            context.SaveChanges();

            var courses = new Coursera[]
            {
                new Coursera{CourseID=1050,Title="Chemistry",Credits=3},
                new Coursera{CourseID=4022,Title="Microeconomics",Credits=3},
                new Coursera{CourseID=4041,Title="Macroeconomics",Credits=3},
                new Coursera{CourseID=1045,Title="Calculus",Credits=4},
                new Coursera{CourseID=3141,Title="Trigonometry",Credits=4},
                new Coursera{CourseID=2021,Title="Composition",Credits=3},
                new Coursera{CourseID=2042,Title="Literature",Credits=4}
            };

            context.Courseras.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollmenter[]
            {
                new Enrollmenter{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollmenter{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollmenter{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollmenter{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollmenter{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollmenter{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollmenter{StudentID=3,CourseID=1050},
                new Enrollmenter{StudentID=4,CourseID=1050},
                new Enrollmenter{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollmenter{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollmenter{StudentID=6,CourseID=1045},
                new Enrollmenter{StudentID=7,CourseID=3141,Grade=Grade.A},
            };

            context.Enrollmenters.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
