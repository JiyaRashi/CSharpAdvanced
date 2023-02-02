using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Concepts
{
    public class StringvsStringBuilder
    {
        

        public void stringvsstringbuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string str2 = " I am ";
            string str3 = "string class";
            string str4 = " I am ";
            string con = str2 + str3;

            str2 += "added";
            str2 += " once again";
            Console.WriteLine($" ---string ==== {con}");
            Console.WriteLine($" ---string equal==== {str4.Equals(str2)}");
            Console.WriteLine($" ---string override==== {str2}");

            //String class will create every time with new object.So Immutable.
            

        }
    }

  
}
