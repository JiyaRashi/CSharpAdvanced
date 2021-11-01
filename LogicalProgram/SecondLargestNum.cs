﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.LogicalProgram
{
   public class SecondLargestNum
    {
        public void GetSendondLargest()
        {
            int[] arr = new int[] { 12, 13, 19,56,1,123 };

            int arr_size = arr.Length;
            int i, first, second, third,fouth;
            int max_Value = 0;


            // There should be atleast three elements
            if (arr_size < 3)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            fouth= third = first = second = 000;
            for (i = 0; i < arr_size; i++)
            {
                // If current element is
                // greater than first
                if (arr[i] > first)
                {
                    fouth = third;
                    third = second;
                    second = first;
                    first = arr[i];
                }

                // If arr[i] is in between first
                // and second then update second
                else if (arr[i] > second)
                {
                    third = second;
                    second = arr[i];
                }

                else if (arr[i] > third)

                    third = arr[i];
                else if (arr[i] > fouth)

                    fouth = arr[i];
            }

            Console.WriteLine("Three largest elements are " + first + " " + second + " " + third + " " +fouth);


            for (int j = 0; j < arr_size -1; j++)
            {
                int val = arr[j] - arr[j + 1];
                int posValue = (Math.Abs(val));
                if (posValue > max_Value)
                {
                    max_Value = posValue;
                }
            }
            Console.WriteLine("Three largest differentitate elements are " + max_Value );

            Console.ReadKey();
        }
    }

   
}
