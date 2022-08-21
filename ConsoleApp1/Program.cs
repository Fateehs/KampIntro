using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2 = 40;
            var result = Add(out number1, number2);
            Console.WriteLine(result);

        }
        static int Add(out int number1, int number2)
        {
            number1 = 60;
            return number1 + number2;
           
        }
    }
}
