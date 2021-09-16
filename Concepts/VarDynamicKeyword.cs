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
            var v = 100;// Now var key is Int Suupose if we assign another data type wont take.
            v = 150;
            //v="This is String"

            // dynamic will accept all the data type display which is asigned in Last.
            dynamic d = "This is String";
            d = 100;
            Console.WriteLine($"----var---{v.ToString()}");
            Console.WriteLine($"----dynamic---{d.ToString()}");

        }
    }
}
