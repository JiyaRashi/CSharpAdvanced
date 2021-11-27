using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpAdvanced.Concepts
{
    public class MultiThread
    {
        public MultiThread()
        {
                
        }

        public void Multi_Thread()
        {
            MultiThread multiThread = new MultiThread();
            ThreadStart threadstart = new ThreadStart(multiThread.Method_2);
            Thread t1 = new Thread(threadstart);
            t1.Start();
            Thread.Sleep(1000);
            Thread t2 = new Thread(threadstart);
            t2.Start();
            Thread.Sleep(1000);
            Thread t3 = new Thread(threadstart);
            t3.Start();
            Thread.Sleep(1000);
            Thread t4 = new Thread(threadstart);
            t4.Start();
            Thread.Sleep(1000);

         //   multiThread.Method_3();
        }
        public void Method_2()
        {
            lock (this)
            {
                Console.Write("[Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("world of dotnet!]");
            }
        }


        public void Method_3()
        {
            
                Console.Write("[Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("world of dotnet!]");
        }
        public void Method_1()
        {
            Mutex mutex = new Mutex();
            mutex.WaitOne();
                Console.Write("[Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("world of dotnet!]");
                 mutex.ReleaseMutex();
        }
    }
}
