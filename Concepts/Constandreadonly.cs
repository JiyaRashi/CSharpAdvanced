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
        readonly string _oldVal;

        readonly static string Val;
        readonly static string Val1;

        // s="This string";
        public Constandreadonly()
        {
            Console.WriteLine($"======Constandreadonly ========");

            // Val = "Hey static readonly";
            //c = 123;
            string _newVal = "New Value ";
            _oldVal= "Old Value";
            _oldVal = _newVal;
            Console.WriteLine($"-------Assigned Value :_oldVal = _newVal-----");
            Console.WriteLine($"------_oldVal: {_oldVal}");

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
            _oldVal = "This string" + val;
            Console.WriteLine($"-------Ctor with Parameter------->{_oldVal}");
        }
    }
}
