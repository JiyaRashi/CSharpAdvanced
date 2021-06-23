using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadKey();


        }

        public abstract class customer
        {

            public abstract void discount();
            
        }

        public abstract class customernoDiscount
        {
            public string name;

        }
        public interface Icustomer_1
        {
            string name { get; set; }

        }

        public interface Icustomer_2
        {
            void discount();

        }

        public class PlantinumCustomer_abstract : customer
        {
            public override void discount()
            {
                Console.WriteLine("50 discount abs");
            }
        }

        public class SilverCustomer_abstract : customer
        {
            public override void discount()
            {
                Console.WriteLine("30 discount abs");
            }
        }

        public class GoldCustomer_abstract : customer
        {
            public override void discount()
            {
                Console.WriteLine("40 discoun abs");
            }
        }

        public class NormalCustomer
        {
            // no discount 
            //  if inherit abstract class ,In situvation need develop discount method in normal class
        }

        public class PlantinumCustomer_Interface : Icustomer_2
        {
            public void discount()
            {
                Console.WriteLine("50 discount interface");
            }
        }

        public class SilverCustomer_Interface : Icustomer_2
        {
            public string name  = "Silver Interface";

            public void discount()
            {
                Console.WriteLine("30 discount interface");
            }
        }

        public class NormalCustomer_Interface : Icustomer_1
        {
            public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
    }
}
