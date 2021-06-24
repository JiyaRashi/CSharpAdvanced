using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class OverrideLoadHide
    {
       
    }

    public class Test1
    {
        public void Method1()
        {
            Console.WriteLine("---Test1---------------Method1");
        }
        public void Method2()
        {
            Console.WriteLine("---Test1---------------Method2");
        }

        public virtual void Method3()
        {
            Console.WriteLine("---Test1-------virtual--------Method3");
        }
        public virtual void Method4()
        {
            Console.WriteLine("---Test1-------virtual--------Method4");
        }
    }

    public class Test2:Test1
    {
        public virtual void Method1()
        {
            Console.WriteLine("---Test2---------------Method1");
        }
        public void Method2()
        {
            Console.WriteLine("---Test2---------------Method2");
        }
        public override void Method3()
        {
            base.Method3();
            Console.WriteLine("---Test2-------override--------Method3");
        }
        public new void Method4()
        {
            Console.WriteLine("---Test2-------override--------Method4");
        }
    }

    public class Test3 : Test1
    {
        
        public new void Method1()
        {
            Console.WriteLine("-------------------------------------");
            base.Method1();
            Console.WriteLine("---Test3---------------Method1");
        }
        public new void Method2()
        {
            Console.WriteLine("---Test3---------------Method2");
        }

        
    }

    public class Test4:Test1
    {
        public new void Method3()
        {
            Console.WriteLine("---Test4---------------Method3");
        }
    }

}
