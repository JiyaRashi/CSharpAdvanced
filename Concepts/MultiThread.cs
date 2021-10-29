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
        Mutex mutex = new Mutex();
        public MultiThread()
        {
                
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

        public void Method_1()
        {
                 mutex.WaitOne();
                Console.Write("[Welcome to the ");
                Thread.Sleep(1000);
                Console.WriteLine("world of dotnet!]");
                 mutex.ReleaseMutex();
        }
    }
}
