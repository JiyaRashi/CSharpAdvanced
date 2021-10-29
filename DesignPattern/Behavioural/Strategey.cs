using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.DesignPattern.Behavioural
{
    public interface ITravelStrategy
    {
        void GoToAirport();

    }
    public class Strategey
    {
        public void Strategey_DesignPattern()
        {
            TravelContext tc = new TravelContext(new BusStrategy());
            tc.GoToAirPort();
        }
    }

    public class TravelContext
    {
        ITravelStrategy _travelStrategy;

        public TravelContext(ITravelStrategy travelStrategy)
        {
            _travelStrategy = travelStrategy;
        }

        public void GoToAirPort()
        {
            _travelStrategy.GoToAirport();
        }
    }

    public class AutoStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("=================Auto========");
        }
    }

    public class BusStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("=================Bus========");
        }
    }

    public class TrainStrategy : ITravelStrategy
    {
        public void GoToAirport()
        {
            Console.WriteLine("=================Train========");
        }
    }

}
