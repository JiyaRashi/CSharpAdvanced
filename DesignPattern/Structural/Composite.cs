using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.DesignPattern.Structural
{
   public interface IComposite
    {
        void Display();
    }
   public class Composite
    {
        public void CompositePattern()
        {
            IComposite emp1 = new Employee("emp_1");
            IComposite emp2 = new Employee("emp_2");
            IComposite emp3 = new Employee("emp_3");

            Manager m1 = new Manager("M1");
            Manager m2 = new Manager("M2");

            m1.AddEmp(emp1);
            m2.AddEmp(emp2);
            m2.AddEmp(emp3);


           // m1.Display();
            //m2.Display();

            Boss b1 = new Boss("Boss 1");
            b1.AddManager(m1);
            b1.AddManager(m2);
            b1.Display();


        }

    }

    public class Employee : IComposite
    {
        public string EmpName { get; set; }

        public Employee(string name)
        {
            EmpName = name;
        }
        public void Display()
        {
            Console.WriteLine($"===EmpName=={EmpName}");
        }
    }

    public class Manager : IComposite
    {
        public string ManagerName { get; set; }
        List<IComposite> composites = new List<IComposite>();

        public Manager(string managerName)
        {
            ManagerName = managerName;
        }
        public void AddEmp(IComposite composite)
        {
            composites.Add(composite);
        }
        public void Display()
        {
            Console.WriteLine(ManagerName);
            foreach (var item in composites)
            {
                item.Display();
            }
        }
    }

    public class Boss : IComposite
    {
        public string BossName { get; set; }
        public Boss(string bossName)
        {
            BossName = bossName;
        }

        public void AddManager(IComposite composite)
        {
            composites.Add(composite);
        }

        List<IComposite> composites = new List<IComposite>();
        public void Display()
        {
            Console.WriteLine(BossName);
            foreach (var item in composites)
            {
                item.Display();
            }
        }
    }
}
