using System;

namespace SumAPlusB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Прочитали первую строку, в которой хранится количество чисел.
            var lengthInput = Console.ReadLine();
            //проверить длину второй строки
            
            // Прочитали вторую строку, в которой хранятся числа через пробел.
            var arrayInput = Console.ReadLine();
           
            // Разделили строку по пробелу. Получили массив строк в перемнной arrayInputValues
            var arrayInputValues = arrayInput.Split(' ');
            var length = int.Parse(lengthInput);
            if (arrayInputValues.Length != length)
            {
                Console.WriteLine("Ошибка.");
            }
            else
            {
                var sum = 0;
                foreach (var stringValue in arrayInputValues)
                {
                    var intValue = int.Parse(stringValue);
                
                    sum += intValue;
                }
            
                //консоль выводит сумму
                Console.WriteLine(sum);
            }
                
            Console.ReadLine();
        }
    }
}
    