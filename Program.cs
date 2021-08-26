using System;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 0;
            int secondnumber = 0;
            int thirdnumber = 0;
            int result = 0;

            Console.Write("Please enter your first number: ");
            firstnumber = int.Parse(Console.ReadLine ());

            Console.Write("Please enter the second number: ");
            secondnumber = int.Parse(Console.ReadLine ());

            Console.Write("Please enter the third number: ");
            thirdnumber = int.Parse(Console.ReadLine ());

            result = firstnumber * secondnumber * thirdnumber;
            Console.WriteLine("The answer is: " + result);
        }
    }
}
