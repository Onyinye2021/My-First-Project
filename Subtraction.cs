using System;

namespace subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            int secondnumber = 0;
            int result = 0;

            Console.Write("Please enter the first number: ");
            firstnumber = int.Parse(Console.ReadLine ());

            Console.Write("Please enter the second number: ");
            secondnumber = int.Parse(Console.ReadLine ());

            result = firstnumber - secondnumber;
            Console.WriteLine("The answer is: " + result);
        }
    }
}
