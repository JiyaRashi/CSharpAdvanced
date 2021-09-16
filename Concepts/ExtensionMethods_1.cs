using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
   public static class ExtensionMethods_1
    {
        public static bool ISGreatJiya(this int num)
        {
            return num < 100 ? false : true;
        }
    }
}
