using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.DesignPattern.Structural
{
    public interface IPizza
    {
        void GetNonVegPizza();
        void GetVegPizza();
    }

    public class RestFacade
    {

        IPizza pizzaProvider;

        public RestFacade()
        {
            pizzaProvider = new PizzaProvider();
        }

        public void NonVegPizza()
        {
            pizzaProvider.GetNonVegPizza();
        }

        public void VegPizza()
        {
            pizzaProvider.GetVegPizza();
        }
    }
    public class Facade
    {
        //Client Code
        RestFacade restFacade = new RestFacade();
        public void GetFacade()
        {
            restFacade.NonVegPizza();
            restFacade.VegPizza();
        }
       
    }

    public class PizzaProvider : IPizza
    {
        public void GetNonVegPizza()
        {
            Console.WriteLine($"==============Plain Non Veg Pizza");
            GetCheesee();
        }

        public void GetCheesee()
        {
            Console.WriteLine($"==============Added Cheesee");
        }

        public void GetVegPizza()
        {
            Console.WriteLine($"==============Plain Veg Pizza");
        }
    }


}
