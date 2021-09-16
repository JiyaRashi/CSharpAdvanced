using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
     public class InterfacevsAbstract
    {
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
            public string name = "Silver Interface";

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
