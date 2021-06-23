using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.ReadKey();


        }
    }
}
