namespace CSharpAdvanced.Collection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class ArrayTheroyClass
    {
        public void ArrayPoint()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            string Note = $"========================Notes=================================";
            string Note_1 = $"When we declare an array by using the “var” keyword then " +
                $"such types of arrays are called implicitly typed arrays in C#.";

            string Advantage = $"===============Advantage================";
            string adv1 = $"It is used to represent similar types of multiple data " +
             $"items using a single name.";
            string adv2 = "We can use arrays to implement other " +
                "data structures such as linked lists, trees, graphs, stacks, queues, etc.";
            string adv3 = $"The two -dimensional arrays in C# are used to represent matrices.";
            string adv4 = $"The Arrays in C# are strongly typed. " +
                $"That means they are used to store similar " +
                $"types of multiple data items using a single name. ";                
            string adv5 = $"Runtime errors will be prevented because of a type mismatch.";
            string adv6 = $"In this case, at compile time it will give you the error " +
                $"if there is a type mismatch.";
            string adv7= $"The performance of the application will be much better" +
                $"because boxing and unboxing will not happen.";

            string DisAdvantage = $"===============DisAdvantage================";

            Console.WriteLine(Note);
            Console.WriteLine(Note_1);
            Console.WriteLine(Advantage);
            Console.WriteLine($"1.{adv1}");
            Console.WriteLine($"2.{adv2}");
            Console.WriteLine($"3.{adv3}");
            Console.WriteLine($"4.{adv4}");
            Console.WriteLine($"5.{adv5}");
            Console.WriteLine($"6.{adv6}");
            Console.WriteLine($"7.{adv7}");
            
            string disAdv1 = $"The array size is fixed. " +
                 $"So, we should know in advance how many elements are going to be stored in the array." +
                 $"Once the array is created, then we can never increase the size of an array. " +
                 $"If you want then we can do it manually by " +
                 $"creating a new array and copying the old array elements into the new array.";
            string disAdv2 = $"As the array size is fixed, " +
                $"if we allocate more memory than the requirement then the extra memory will be wasted. " +
                $"On the other hand, if we allocate less memory than the requirement, " +
                $"then it will create the problem.";
            string disAdv3 = $"We can never insert an element into the middle of an array. " +
                $"It is also not possible to delete or remove elements from the middle of an array";


            Console.WriteLine(DisAdvantage);
            Console.WriteLine($"1.{disAdv1}");
            Console.WriteLine($"2.{disAdv2}");
            Console.WriteLine($"3.{disAdv3}");

        }
    }
}
