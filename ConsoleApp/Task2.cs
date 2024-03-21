using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Task2
    {
        //2. Выборка чётных чисел из последовательности:
        //•	Дан список чисел: `11, 23, 60, 57, 62, 17, 42, 34, 123`.
        //•	Напишите программу, которая найдёт и выведет в консоль все чётные числа из этой последовательности.


        public static int[] EvenNumbers(int[] numbers) 
        {
            var evenNumbers = numbers.Where(num =>  num % 2==0 ).ToArray();
            Console.WriteLine(evenNumbers);

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            return evenNumbers;
        }
    }
}
