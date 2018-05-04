using System;

namespace SumAPlusB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputValues = input.Split(' ');
            var a = int.Parse(inputValues[0]);
            var b = int.Parse(inputValues[1]);
            Console.WriteLine(a + b);

            Console.ReadLine();
        }
    }
}