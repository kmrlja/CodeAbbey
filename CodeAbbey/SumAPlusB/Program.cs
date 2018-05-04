using System;

namespace SumAPlusB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                var inputValues = input.Split(' ');

                if (inputValues.Length != 2)
                {
                    Console.WriteLine("Нужно ввести два числа через пробел.");
                }
                else
                {
                    var aIsCorrect = int.TryParse(inputValues[0], out var a);
                    if (!aIsCorrect)
                    {
                        Console.WriteLine("Нужно ввести число.");
                        continue;
                    }
                    var bIsCorrect  = int.TryParse(inputValues[1], out var b);
                    if (!bIsCorrect) 
                    {
                        Console.WriteLine("Нужно ввести число.");
                        continue;
                    }
        
                    Console.WriteLine(a + b);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}