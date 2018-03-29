using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the grades. (Please separate by a comma)");
            var foo = Console.ReadLine();
            var tokens = foo.Split(',');
            List<int> nums = new List<int>();
            int oneNum;
            foreach (var s in tokens)
            {
                if (Int32.TryParse(s, out oneNum))
                    nums.Add(oneNum);
            }

            int sum = nums.Sum();
            Console.WriteLine("The sum of the " + tokens.Length + " grades entered is: " + sum);

            char grade;
            double avg = sum / tokens.Length;

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
        }


    }
}
