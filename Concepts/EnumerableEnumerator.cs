using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Concepts
{
    public class EnumerableEnumerator
    {
        private IEnumerable<string> GetCollection_1()
        {
            List<string> month = new List<string>();
            month.Add("January");
            month.Add("February");
            month.Add("March");
            month.Add("April");
            month.Add("May");
            month.Add("June");
            month.Add("July");
            month.Add("August");
            month.Add("September");
            month.Add("October");
            month.Add("November");
            month.Add("December");

            return month;
        }

        private IEnumerator<string> GetCollection_2()
        {
            List<string> month = new List<string>();
            month.Add("January");
            month.Add("February");
            month.Add("March");
            month.Add("April");
            month.Add("May");
            month.Add("June");
            month.Add("July");
            month.Add("August");
            month.Add("September");
            month.Add("October");
            month.Add("November");
            month.Add("December");

            return month.GetEnumerator();
        }

        private IList<string> GetCollection_3()
        {
            List<string> month = new List<string>();
            month.Add("January");
            month.Add("February");
            month.Add("March");
            month.Add("April");
            month.Add("May");
            month.Add("June");
            month.Add("July");
            month.Add("August");
            month.Add("September");
            month.Add("October");
            month.Add("November");
            month.Add("December");

            return month;
        }


        public void IterateCollection_1()
        {
            foreach (string item in GetCollection_1())
            {
                if(item== "May")
                Console.WriteLine($"-IterateCollection_1---May");
                else
                    Console.WriteLine($"-IterateCollection_1---{item}");
            }
        }

        public void IterateCollection_2()
        {
            IEnumerator<string> i = GetCollection_2();
            while(i.MoveNext())
            {
                if (i.Current == "May")
                {
                    Print_2(i);
                    Console.WriteLine($"-IterateCollection_2---May");
                }
                else
                    Console.WriteLine($"-IterateCollection_2---{i.Current}");
            }
        }

        public void IterateCollection_3()
        {
            foreach (string item in GetCollection_3())
            {
                if (item == "May")
                {
                    Print_3(item);
                    Console.WriteLine($"-IterateCollection_3---May");
                }
                else
                    Console.WriteLine($"-IterateCollection_3---{item}");
            }
        }

        public void Print_2(IEnumerator<string> i)
        {
            Console.WriteLine($"---------Print_2-------{i.Current}");
        }
        public void Print_3(string i)
        {
            Console.WriteLine($"---------Print_3-------{i}");
        }
    }
}
