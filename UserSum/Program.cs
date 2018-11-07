using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Make a console application that takes 2 numbers as user input, and returns the sum

namespace UserSum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number..");
            double First = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number..");
            double Second = double.Parse(Console.ReadLine());
            Console.WriteLine(AddValues(First, Second));
        }

        static public double AddValues(double First, double Second)
        {
            double sum = First + Second;
            Console.WriteLine($"The sum of these two number is: ");
            return sum;
        }
    }
}
