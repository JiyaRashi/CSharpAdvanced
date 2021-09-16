using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Collection.TheoryCollection
{
    public class TheoryConcepts
    {
        public void ReadTheroy()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.White;
            using (StreamReader sr = 
                new StreamReader(
                    @"D:\DOT NET\Jiya\CSharpAdvanced\CSharpAdvanced\Collection\TheoryCollection\ConceptDefn.txt"))
            {

                String line;
                // Read line by line
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                }
            }
        }
    }
}
