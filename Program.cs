﻿
namespace CSharpAdvanced
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            CSharp_Utility _commonUtility = new CSharp_Utility();

            EF_Utility eF_Utility = new EF_Utility();

            eF_Utility.GetAllStudents();
           // _commonUtility.InterfaceAbstract();

            // _commonUtility.SecondLargest();
            // _commonUtility.TheoryConcepts();
            // _commonUtility.Factory_Method_DesignPattern();
            Console.Read();

        }
       

    }
}
