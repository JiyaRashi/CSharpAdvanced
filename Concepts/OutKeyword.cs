using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class OutKeyword
    {
        public void RefvsOut()
        {
            #region Ref and Out keyword
            OutKeyword outkey = new OutKeyword();
            int num;
            outkey.sum(out num);
            Console.WriteLine($" out---------------------{num}");

            int xx;
            int yy;
            outkey.multipleNum(out xx, out yy);
            Console.WriteLine($" out-------------X = {xx}  Y = {yy}-----");

            int refx = 10;
            int refy = 20;

            outkey.multipleRef(ref refx, ref refy);
            Console.WriteLine($" ref-------------X = {refx}  Y = {refy}-----");

            int aa = 5;
            int bb = 9;
            outkey.tricky(ref aa, out bb);
            Console.WriteLine($" tricky-------------X = {aa}  Y = {bb}-----");
            #endregion
        }
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
