using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
           int fisrtnumber = 0;
           int secondnumber = 0;
           int result = 0;

           Console.Write("Please enter the first number: ");
           fisrtnumber = int.Parse(Console.ReadLine ());

           Console.Write("Please enter the second number: ");
           secondnumber = int.Parse(Console.ReadLine ());

           result = fisrtnumber / secondnumber;
           Console.WriteLine("The answer is: " + result);


        }
    }
}
