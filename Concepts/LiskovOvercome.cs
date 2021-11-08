using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Concepts
{
    public class LiskovOvercome
    {
        public void Liskov_Overcome()
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());

            Fruit fruit = new Orange_o();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple_o();
            Console.WriteLine(fruit.GetColor());
        }
    }

    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple_o : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange_o : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
