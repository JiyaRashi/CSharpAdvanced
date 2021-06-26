using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
   public class ExtensionMethods_2
    {

    }

    public class Logger
    {
        public void Log(string message, string MessageType)
        {
            Console.WriteLine($"Log:{message}");
        }

        public void LoggerData(string message,string MessageType)
        {
            Console.WriteLine($"{MessageType}:{message}");
        }
    }
    
}
