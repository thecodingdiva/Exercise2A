﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersInput = new List<string>();

            Console.WriteLine("Please enter 10 numbers between 1 and 100 ");
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                numbersInput.Add(input);
                Console.WriteLine("Please enter another integer: ");
                input = Console.ReadLine();
            }

            if (numbersInput.Count > 0)
            {
                Console.WriteLine("You have entered " + numbersInput.Count + " numbers, they were: ");
                NewMethod(numbersInput);
            }
            else
            {
                Console.WriteLine("You have entered 0 numbers.");  
            }

        }

        private static void NewMethod(List<string> numbersInput)
        {
            foreach (var input in numbersInput)
            {
                Console.WriteLine("\t" + input);
            }
        }
    }
}