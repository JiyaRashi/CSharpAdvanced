using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpAdvanced.DelegatevsEvents;
using static CSharpAdvanced.InterfacevsAbstract;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            #region interface vs abstract
            PlantinumCustomer_abstract pc_abs = new PlantinumCustomer_abstract();
            pc_abs.discount();

            SilverCustomer_abstract sc_abs = new SilverCustomer_abstract();
            sc_abs.discount();

            GoldCustomer_abstract gc_abs = new GoldCustomer_abstract();
            gc_abs.discount();


            PlantinumCustomer_Interface pc_interface = new PlantinumCustomer_Interface();
            pc_interface.discount();
            //Icustomer_1 ic1 = new PlantinumCustomer_Interface();
            //ic1.name = "Plantinum";

            SilverCustomer_Interface sc_interface = new SilverCustomer_Interface();
            sc_interface.discount();
            sc_interface.name = "Silver";
            #endregion


            DelegatevsEvents delegatevsEvents = new DelegatevsEvents();

            //int add= delegatevsEvents.Add(5, 6);
            //int mul = delegatevsEvents.multiplication(5, 6);
            //Console.WriteLine($"Add ----------------------> {add}");
            //Console.WriteLine($"Mul ----------------------> {mul}");


            CalcDegate del1=new CalcDegate(delegatevsEvents.Add);
            //CalcDegate del2 = new CalcDegate(delegatevsEvents.multiplication);

            del1 += new CalcDegate(delegatevsEvents.multiplication);
            del1 += new CalcDegate(delegatevsEvents.sub);

            del1 += null;
            //del1 = null;  //-----------------------------suppose if assgin null value to delegate its gives on run time error 

            del1(3, 3);
            delegatevsEvents.calcDegatEvent += new DelegatevsEvents.calcDegateHandler(delegatevsEvents.Addevents);
            //delegatevsEvents.calcDegatEvent += new DelegatevsEvents.calcDegateHandler(delegatevsEvents.sub);
            //delegatevsEvents.calcDegatEvent += new DelegatevsEvents.calcDegateHandler(delegatevsEvents.multiplication);



            // del2(5, 5);
            int a = 56;
             bool result=a.ISGreatJiya();
            Console.WriteLine($"--------------------Extension method {result} ");

            #region Ref and Out keyword
            OutKeyword outkey = new OutKeyword();
            int num;
            outkey.sum(out  num);
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
            int bb;
            outkey.tricky(ref aa, out bb);
            Console.WriteLine($" tricky-------------X = {aa}  Y = {bb}-----");
            #endregion

            #region Override Hiding
            Test1 t1 = new Test1();
            t1.Method1();
            t1.Method2();
            Console.WriteLine("-----------------------------------------------");

            Test2 t2 = new Test2();
            t2.Method1();
            t2.Method2();
            Console.WriteLine("-----------------------------------------------");


            Test1 tt1 = new Test2();
            tt1.Method1();
            tt1.Method2();
            tt1.Method3();
            tt1.Method4();
            Console.WriteLine("-----------------------------------------------");


            Test3 t3 = new Test3();
            t3.Method1();
            t3.Method2();
            Console.WriteLine("-----------------------------------------------");
            Test1 ttt1 = new Test3();
            ttt1.Method2();
            Console.WriteLine("--------------------------------t4---------------");
            Test1 t4 = new Test4();
            t4.Method3(); 
            #endregion

            ////Test3 tt3 = new Test2();
            //tt3.Method1();
            //tt3.Method2();

            Console.ReadKey();


        }
              
    }
}
