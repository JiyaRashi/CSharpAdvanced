using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.DesignPattern.Structural
{
    public interface Icar
    {
        Icar Manufacture();
    }
   public  class Decorator
    {
        public void Decorator_Pattern()
        {
            Icar car = new BMWCar();
            car.Manufacture();
            DiselCarDecorator diselCarDecorator = new DiselCarDecorator(car);
            diselCarDecorator.Manufacture();

        }

    }

    public class BMWCar : Icar
    {
        public void Name()
        {
            Console.WriteLine("============BMW CAR=============");
        }
        public void EngineTyep()
        {
            Console.WriteLine("============EngineTyep=============");
        }

        public Icar Manufacture()
        {
            return this;
        }
    }

    public abstract class CarDecorator : Icar
    {
        protected Icar Car;
        public CarDecorator(Icar car)
        {
            this.Car = car;
        }
        public virtual Icar Manufacture()
        {
            return Car.Manufacture();
        }
    }

    public class DiselCarDecorator : CarDecorator
    {
        public DiselCarDecorator(Icar car):base(car)
        {

        }

        public override Icar Manufacture()
        {
            Car.Manufacture();
            BMWDiselEngine();
            return Car;
        }

        private void BMWDiselEngine()
        {
            Console.WriteLine("======================BMW Added Disel");
        }
    }
}
