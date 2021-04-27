using System;

namespace AverageSeek_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //declares variables
            double num01;
            double num02;
            double num03;
            double sum;
            double average;

            double result;

            //gets user input for variables
            Console.Write("Please pick a number: " );
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please pick a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please pick a third number: ");
            num03 = Convert.ToDouble(Console.ReadLine());

            //finds average of the three, and outputs it
            sum = num01 + num02 + num03;
            average = sum / 3;

            Console.Write("The sum of those numbers is " + sum + "\nThe average of those numbers is: " + average);

            //waits before closing
            Console.ReadKey();
        }
    }
}
