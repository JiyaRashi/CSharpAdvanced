using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Concepts
{
    class LiskovOvercome
    {
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
}
