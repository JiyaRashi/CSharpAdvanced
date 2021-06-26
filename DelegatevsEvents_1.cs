using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class DelegatevsEvents_1
    {
        public delegate int CalcDegate(int x, int y);

        public CalcDegate calcDegater;

        public delegate int calcDegateHandler(int x, int y);


        public event calcDegateHandler calcDegatEvent;


        public int Add(int x ,int y)
        {
            Console.WriteLine($"-------------Add------{x + y}");
            return x + y;
        }

        public int multiplication(int x, int y)
        {
            Console.WriteLine($"-------------mul------{x * y}");

            return x * y;
        }

        public int sub(int x, int y)
        {
            Console.WriteLine($"-------------sub------{x - y}");

            return x - y;
        }

        public int Addevents(int x, int y)
        {
            Console.WriteLine($"-------------Add events------");
            return 5;
        }
    }
}
