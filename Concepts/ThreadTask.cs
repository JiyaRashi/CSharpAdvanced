using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class ThreadTask
    {
        int _number;
        public ThreadTask(int number)
        {
            _number = number;
        }
        public void Method1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"-Method 1-{i}");
                Thread.Sleep(200);
            }

        }
        public void Method2(object target) // only object 
        {
            int _target = Convert.ToInt32(target);

            for (int i = 0; i < _number; i++)
            {
                Console.WriteLine($"-Method 2-{i}");
                Thread.Sleep(200);
            }
        }

        public void Method3()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"-Method 3-{i}");
                Thread.Sleep(200);
            }
        }

        public int Method4()
        {
            return 55;
        }
    }

}
