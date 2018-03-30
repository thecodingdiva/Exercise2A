﻿using System;
using System.CodeDom;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Remoting.Channels;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            ////BASIC

            //decimal[] array = new Decimal[10];
            //Console.WriteLine("Enter the 10 test scores.");
            //for (int i = 0; i < 10; i++)
            //{
            //    array[i] = Convert.ToDecimal(Console.ReadLine());
            //}

            //decimal sum = 0;

            //foreach (decimal d in array)
            //{
            //    sum += d;
            //}

            //decimal avg = sum / 10;


            //Console.WriteLine("The sum of the 10 grades entered is: " + avg);

            //char grade;

            //if (avg >= 90)
            //{
            //    grade = 'A';
            //}
            //else if (avg > 80)
            //{
            //    grade = 'B';
            //}
            //else if (avg > 70)
            //{
            //    grade = 'C';
            //}
            //else if (avg > 60)
            //{
            //    grade = 'D';
            //}
            //else
            //{
            //    grade = 'F';
            //}

            //Console.WriteLine("The average of the grades is: " + avg);
            //Console.WriteLine("The letter grade is: " + grade);


            //INTERMEDIATE

            int i = 0;
            int[] array = new int[i];

            Console.WriteLine("How many tests do you have?");
            int end = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Please enter a number to add to the array or \"x\" to stop: ");
                string consoleInput = Console.ReadLine();
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());

                }
                while (array.Length < end) ;


                int sum = 0;

                foreach (int d in array)
                {
                    sum += d;
                }

                decimal avg = sum / 10;


                Console.WriteLine("The sum of the 10 grades entered is: " + avg);

                char grade;

                if (avg >= 90)
                {
                    grade = 'A';
                }
                else if (avg > 80)
                {
                    grade = 'B';
                }
                else if (avg > 70)
                {
                    grade = 'C';
                }
                else if (avg > 60)
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'F';
                }

                Console.WriteLine("The average of the grades is: " + avg);
                Console.WriteLine("The letter grade is: " + grade);


                ////ADVANCED

                //Console.WriteLine("Please enter the grades. (Please separate by a comma)");
                //    var foo = Console.ReadLine();
                //    var tokens = foo.Split(',');
                //    List<int> nums = new List<int>();
                //    int oneNum;
                //    foreach (var s in tokens)
                //    {
                //        if (Int32.TryParse(s, out oneNum))
                //            nums.Add(oneNum);
                //    }

                //    int sum = nums.Sum();
                //    Console.WriteLine("The sum of the " + tokens.Length + " grades entered is: " + sum);

                //    char grade;
                //    double avg = sum / tokens.Length;

                //    if (avg >= 90)
                //    {
                //        grade = 'A';
                //    }
                //    else if (avg > 80)
                //    {
                //        grade = 'B';
                //    }
                //    else if (avg > 70)
                //    {
                //        grade = 'C';
                //    }
                //    else if (avg > 60)
                //    {
                //        grade = 'D';
                //    }
                //    else
                //    {
                //        grade = 'F';
                //    }

                //    Console.WriteLine("The average of the grades is: " + avg);
                //    Console.WriteLine("The letter grade is: " + grade);
                //}

            }
        

    }
    }
}
