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
        public void Thread_Task()
        {
            ThreadTask asyncawait = new ThreadTask(3);
            Console.WriteLine("------------------------------Start Main Thread---------------");

            Thread t1 = new Thread(asyncawait.Method1);
            t1.Start();
            t1.IsBackground = true;

            ParameterizedThreadStart pts = new ParameterizedThreadStart(asyncawait.Method2);
            Thread t2 = new Thread(pts);
            t2.Start();

            //t2.Start("jiya");

            ThreadStart threadStart = new ThreadStart(asyncawait.Method3);
            Thread t3 = new Thread(threadStart);
            t3.Start();
            Console.WriteLine("------------------------------End Main Thread---------------");


            Task task1 = new Task(asyncawait.Method3);
            task1.Start();

            Task<int> taskretturn = new Task<int>(asyncawait.Method4);
            taskretturn.Start();
            Console.WriteLine($"--------taskretturn-----{taskretturn.Result}----------");

            Parallel.Invoke(() =>
            {
                asyncawait.Method1();
            },
                () =>
                {
                    object aa = 9;
                    asyncawait.Method2(aa);
                }

            );
        }
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

            for (int i = 0; i < _target; i++)
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
