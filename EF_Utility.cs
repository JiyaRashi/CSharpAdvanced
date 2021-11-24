using CSharpAdvanced.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class EF_Utility
    {
        Student addStudent = new Student()
        {
            StudentId = 6,
            StandardId = 1,
            FirstName = "Jiya",
            LastName = "Rashee",

        };
        public void GetAllStudents()
        {
            
            using(var context= new EF_Demo_DBEntities())
            {

                List<Student> students = context.Students.ToList();

                foreach (var item in students)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} {item.Standard}");
                }

                context.Students.Add(addStudent);
                context.SaveChanges();


                foreach (var item in context.spGetCoursesByStudentId(1))
                {
                    Console.WriteLine($"{item.CourseId} {item.CourseName}");

                }

            }
        }

        public void UpdatedStudents()
        {
            using (var context = new EF_Demo_DBEntities())
            {
                context.spUpdateStudent(addStudent.StudentId, addStudent.StandardId, addStudent.FirstName, addStudent.LastName);
                context.SaveChanges();
            }
        }
    }
}
