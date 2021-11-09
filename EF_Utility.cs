using CSharpAdvanced.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class EF_Utility
    {
        public void GetAllStudents()
        {
            using(var context= new EF_Demo_DBEntities())
            {

                List<Student> students = context.Students.ToList();

                foreach (var item in students)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} {item.Standard}");
                }
            }
        }
    }
}
