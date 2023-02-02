using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
   public static class ExtensionEx    {
        public static bool ISGreatJiya(this int num)
        {
            return num < 100 ? false : true;
        }

        public static void GetExclassfunc(this Ex1 obj )
        {
            obj.Display();
            obj.print();
        }

        public static int GetWordCount(this string val)
        {
            if (!string.IsNullOrEmpty(val))
            {
                string[] arr = val.Split(' ');
                return arr.Count();
            }
            return 0;
        }
        //public  bool Is_GreatJiya(this int num)
        //{
        //    return num < 100 ? false : true;
        //}
    }

    public class Ex1
    {
        public void Display()
        {
            Console.WriteLine($"--------Display------ ");
        }

        public void print()
        {
            Console.WriteLine($"--------Print------ ");
        }

        string val = "Hi i am Jiyavudeen implemented Extented";
        
        public void GetworodCount()
        {
            int countword= val.GetWordCount();
            Console.WriteLine($"====word count ===={countword} ");
        }


    }
      
    // if want to add some method implenetation using exitisting class

   // Extension methods allow existing classes to be extended without relying on inheritance or having to change the class's source code.
   //If the class is sealed than there in no concept of extending its functionality.For this a new concept is introduced, in other words extension methods.
   //This feature is important for all developers, especially if you would like to use the dynamism of the C# enhancements in your class's design.
}
