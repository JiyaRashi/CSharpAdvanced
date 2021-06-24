using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class OutKeyword
    {

        //public void Display()
        //{
        //    Console.WriteLine($" out---------------------{number}");
        //}

        public void sum(out int N)
        {
            N = 90;
            N += N;
        }

        public void multipleNum(out int x,out int y)
        {
            x =  5;
            y =  10;
        }


        public void multipleRef(ref int x,ref int y)
        {
            x = 55;
            y = 100;
        }

        public void tricky(ref int a, out int b)
        {
            a = 7;
            b = 2;
        }

    }
}
