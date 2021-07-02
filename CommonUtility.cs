using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CSharpAdvanced.DelegatevsEvents_1;
using static CSharpAdvanced.InterfacevsAbstract;

namespace CSharpAdvanced
{
    public class CommonUtility
    {
        public void InterfaceAbstract()
        {
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
        }
        public void DelegateEvent_1()
        {
            #region Delegate Events
            DelegatevsEvents_1 delegatevsEvents = new DelegatevsEvents_1();

            //int add= delegatevsEvents.Add(5, 6);
            //int mul = delegatevsEvents.multiplication(5, 6);
            //Console.WriteLine($"Add ----------------------> {add}");
            //Console.WriteLine($"Mul ----------------------> {mul}");


            CalcDegate del1 = new CalcDegate(delegatevsEvents.Add);
            //CalcDegate del2 = new CalcDegate(delegatevsEvents.multiplication);

            del1 += new CalcDegate(delegatevsEvents.multiplication);
            del1 += new CalcDegate(delegatevsEvents.sub);

            del1 += null;
            //del1 = null;  //-----------------------------suppose if assgin null value to delegate its gives on run time error 

            del1(3, 3);
            delegatevsEvents.calcDegatEvent += new DelegatevsEvents_1.calcDegateHandler(delegatevsEvents.Addevents);
            //delegatevsEvents.calcDegatEvent += new DelegatevsEvents.calcDegateHandler(delegatevsEvents.sub);
            //delegatevsEvents.calcDegatEvent += new DelegatevsEvents.calcDegateHandler(delegatevsEvents.multiplication);

            #endregion
        }
        public void DelegateEvent_2()
        {
            Video video = new Video();
            Services _service = new Services();
            VideoEncode videoEncode = new VideoEncode();
            videoEncode.VideoEncoding();
            videoEncode.VideoEvent += _service.Mail;
            videoEncode.VideoEvent += _service.SMS;
            videoEncode.OnEncoded(video);
        }
        public void ExtensionMethods_1()
        {
            int a = 56;
            bool result = a.ISGreatJiya();
            Console.WriteLine($"--------------------Extension method {result} ");
        }
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
            int bb;
            outkey.tricky(ref aa, out bb);
            Console.WriteLine($" tricky-------------X = {aa}  Y = {bb}-----");
            #endregion
        }
        public void OverrideHiding()
        {
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
        }
        public void ThreadTask()
        {
            ThreadTask asyncawait = new ThreadTask(3);
            Console.WriteLine("------------------------------Start Main Thread---------------");

            Thread t1 = new Thread(asyncawait.Method1);
            t1.Start();
            t1.IsBackground = true;

            ParameterizedThreadStart pts = new ParameterizedThreadStart(asyncawait.Method2);
            Thread t2 = new Thread(pts);
            t2.Start();

            //t2.Start("jiya");

            ThreadStart threadStart = new ThreadStart(asyncawait.Method3);
            Thread t3 = new Thread(threadStart);
            t3.Start();
            Console.WriteLine("------------------------------End Main Thread---------------");


            Task task1 = new Task(asyncawait.Method3);
            task1.Start();

            Task<int> taskretturn = new Task<int>(asyncawait.Method4);
            taskretturn.Start();
            Console.WriteLine($"--------taskretturn-----{taskretturn.Result}----------");

            Parallel.Invoke(() =>
            {
                asyncawait.Method1();
            },
                () =>
                {
                    object aa = 9;
                    asyncawait.Method2(aa);
                }

            );
        }
        public void ExtensionMethods_2()
        {
            Logger _logger = new Logger();
            _logger.LogError("Thrown Error");
            _logger.LogInfo("Print Value");
            _logger.LogWarning("This not intened");

        }

        public void VarDynamic()
        {
            VarDynamicKeyword.VarDynamic();
        }
    }
}
