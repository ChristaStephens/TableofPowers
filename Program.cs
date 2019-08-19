using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Friend! Welcome to the Table Of Powers");
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            int squared = number * number;
            int cubed = number * number * number;
            Console.WriteLine(number + squared + cubed);
        }
    }
}
