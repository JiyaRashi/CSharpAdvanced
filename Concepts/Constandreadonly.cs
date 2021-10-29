using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
   public class Constandreadonly
    {
        const int c = 100;// need to provide value at time declartion 
        //c =150;
        readonly string s;

        readonly static string Val;
        readonly static string Val1;

        // s="This string";
        public Constandreadonly()
        {
           // Val = "Hey static readonly";
            //c = 123;
            string v = "changed ";
            s="This string";
            s = v;
            Console.WriteLine($"-------Ctor ------->{s}");
        }


        public void Method()
        {
          // s = "This string";
        }

        static Constandreadonly()
        {
            Val = "Hey static readonly";
            Val1 = "again readonly static";
            Val = Val1;
            Console.WriteLine($"-------static Ctor------->{Val}");

        }
        public Constandreadonly(string val)
        {
            //Val = "dfdf";
            s = "This string" + val;
            Console.WriteLine($"-------Ctor with Parameter------->{s}");
        }
    }
}
