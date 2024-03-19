using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Task1
    {
        //Извлечение положительных двузначных чисел из последовательности:
        //У вас есть ряд чисел: `11, -21, 64, 59, 11, 0, -7, 53, -31, 1`.
        //Напишите программу, которая выберет из них все положительные двузначные числа и отсортирует их по возрастанию.
        //Выведите полученную последовательность чисел на консоль.


        public static void SelectNumber(int[] numbers)
        {
            var positiveNum = numbers.Where(num => num > 9 && num < 100).OrderBy(num => num);
            Console.WriteLine(positiveNum);
            
            foreach (var number in positiveNum)
            {
                Console.WriteLine(number);  
            }
        }
    }
}
