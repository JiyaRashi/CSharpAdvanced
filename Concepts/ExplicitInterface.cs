using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Concepts
{
    public interface I1
    {
       void  Display();
    }
    public interface I2
    {
        void Display();
    }
    public class ExplicitInterface 
    {
       public void Explicit_Interface()
        {
            Interface_Check Interface_Check = new Interface_Check();
            Interface_Check.Display();

            I1 i1 = new Interface_Check();
            I1 i2 = new Interface_Check();

            i1.Display();
            i2.Display();

            Console.WriteLine($" Type Casting Method");

            ((I1)Interface_Check).Display();
            ((I2)Interface_Check).Display();

        }
    }

    public class Interface_Check: I1, I2
    {
        public void Display()
        {
            Console.WriteLine($" Clsss DisPlay");
        }

        void I1.Display()
        {
            Console.WriteLine($" I1 DisPlay");
        }
        void I2.Display()
        {
            Console.WriteLine($" I2 DisPlay");
        }
    }

}
