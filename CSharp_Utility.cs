using CSharpAdvanced.Collection;
using CSharpAdvanced.Collection.TheoryCollection;
using CSharpAdvanced.Concepts;
using CSharpAdvanced.DesignPattern;
using CSharpAdvanced.DesignPattern.Behavioural;
using CSharpAdvanced.DesignPattern.FactoryDesignPattern;
using CSharpAdvanced.DesignPattern.Structural;
using CSharpAdvanced.LogicalProgram;
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
    public class CSharp_Utility
    {
        public void InterfaceAbstract()
        {
            #region interface vs abstract
            PlantinumCustomer_abstract pc_abs = new PlantinumCustomer_abstract();
            //pc_abs.discount();

            //SilverCustomer_abstract sc_abs = new SilverCustomer_abstract();
            //sc_abs.discount();

            //GoldCustomer_abstract gc_abs = new GoldCustomer_abstract();
            //gc_abs.discount();


            //PlantinumCustomer_Interface pc_interface = new PlantinumCustomer_Interface();
            //pc_interface.discount();
            ////Icustomer_1 ic1 = new PlantinumCustomer_Interface();
            ////ic1.name = "Plantinum";

            //SilverCustomer_Interface sc_interface = new SilverCustomer_Interface();
            //sc_interface.discount();
            //sc_interface.name = "Silver";
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
            outkey.RefvsOut();
            #endregion
        }
        public void OverrideHiding()
        {
            OverrideLoadHide overrideLoadHide = new OverrideLoadHide();
            overrideLoadHide.OverrideHiding();
        }
        public void ThreadTask()
        {
            ThreadTask t = new ThreadTask(6);
            t.Thread_Task();
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

        public void ConstReadOnly()
        {

            //Constandreadonly cr = new Constandreadonly("Change my String");
            Constandreadonly cr1 = new Constandreadonly();
            Constandreadonly cr2 = new Constandreadonly();
            Constandreadonly cr3 = new Constandreadonly();
            //Static constrctor will be called once no matter how many object has been created
        }

        public void ArrayConcepts()
        {
            ArrayTheroyClass array = new ArrayTheroyClass();
            array.ArrayPoint();
        }

        public void TheoryConcepts()
        {
            TheoryConcepts theoryConcepts = new TheoryConcepts();
            theoryConcepts.ReadTheroy();
        }

        public void Liskov()
        {
            LiskovOvercome liskovOvercome = new LiskovOvercome();
            liskovOvercome.Liskov_Overcome();
        }

        

       
        public void EnumerableEnumeratior_1()
        {
            EnumerableEnumerator ee = new EnumerableEnumerator();
            ee.IterateCollection_1();
        }

        public void EnumerableEnumeratior_2()
        {
            EnumerableEnumerator ee = new EnumerableEnumerator();
            ee.IterateCollection_3();
        }

        public void Multi_Thread()
        {
            MultiThread multiThread = new MultiThread();
            multiThread.Multi_Thread();
        }

        public void Explicit_Interface()
        {
            ExplicitInterface ExplicitInterface = new ExplicitInterface();
            ExplicitInterface.Explicit_Interface();
        }

        public void Factory_DesginPattern()
        {
            FactoryDesignPattern factoryDesignPattern = new FactoryDesignPattern();
            factoryDesignPattern.FDPattern();
        }

        public void Abs_Factory_DesginPattern()
        {
            AbstractFactoryDesignPattern abstractFactoryDesignPattern = new AbstractFactoryDesignPattern();
            abstractFactoryDesignPattern.AbsFactoryPattern();
        }

        public void Composite_DesignPattern()
        {
            Composite composite = new Composite();
            composite.CompositePattern();
        }

        public void Facade_DesignPattern()
        {
            Facade facade = new Facade();
            facade.GetFacade();
        }

        public void Decorator_DesignPattern()
        {
            Decorator decorator = new Decorator();
            decorator.Decorator_Pattern();
        }

        public void Strategey_DesignPattern()
        {
            Strategey strategey = new Strategey();
            strategey.Strategey_DesignPattern();
        }

        public void SecondLargest()
        {
            SecondLargestNum secondLargestNum = new SecondLargestNum("");
            secondLargestNum.GetSendondLargest();
        }
    }
}
