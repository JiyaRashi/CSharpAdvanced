using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
   public static class ExtensionMethods_2
    {
        public static void LogError(this Logger logger,string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log($"Error ---{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void LogInfo(this Logger logger, string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            logger.Log($"Info ---{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void LogWarning(this Logger logger, string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log($"Warning ---{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log:{message}");
        }

        public void Log(string messageType, string message)
        {
            Console.WriteLine($"{messageType}:{message}");
        }
    }
    
}
