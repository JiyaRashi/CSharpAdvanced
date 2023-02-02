using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
   public class Constandreadonly
    {
        const string constval_old = "const old vlaue";
        const string  constval_new = "const new value";



        // need to provide value at time declartion 
        //c =150;
        readonly string _oldVal = "Prefix";
        readonly string _newVal = "New Value";

        readonly static string stativVal_old;
        readonly static string stativVal_new;

        // s="This string";
        public Constandreadonly()
        {
            Console.WriteLine($"======Public ===readonly ================");

            // Val = "Hey static readonly";
            //c = 123;
           
           // _oldVal= "Old Value";
            _oldVal = _newVal;
            Console.WriteLine($"-ctor------Assigned Value :_oldVal = _newVal-----");
            Console.WriteLine($"-ctor-----_oldVal: {_oldVal}");

            Console.WriteLine($"======Public ===Constant ================");
            //constval_old = "";
           // const string constval_olddd = "";

        }

        static Constandreadonly()
        {
            Console.WriteLine($"======static ===readonly ================");

            stativVal_old = "old static value";
            stativVal_new = "new static value";
            stativVal_old = stativVal_new;
            Console.WriteLine($"-ctor------Assigned Value :stativVal_old = stativVal_new-----");
            Console.WriteLine($"-ctor------static Ctor------->{stativVal_old}");

        }
        public Constandreadonly(string val)
        {
            Console.WriteLine($"=========Constandreadonly ======method Param==========");

            //Val = "dfdf";
            _oldVal = $"This string { val}";// ex 1
            _oldVal = $"{_oldVal} This string { val}";// ex 2

            
            Console.WriteLine($"-------Ctor with Parameter------->{_oldVal}");
        }


        //==============================Points to rember ===============================
           // const value cannt be changed 
           // readonly value can be changed  using ctor
           // static readonly can be changes using static ctor
    }
}
