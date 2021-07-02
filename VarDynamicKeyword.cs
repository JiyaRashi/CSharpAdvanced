using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public static class VarDynamicKeyword
    {
        public static void VarDynamic()
        {
            var v = 100;
            v = 150;
            //v="This is String"

            dynamic d = "This is String";
            d = 100;
            Console.WriteLine($"----var---{v.ToString()}");
            Console.WriteLine($"----dynamic---{d.ToString()}");

        }
    }
}
