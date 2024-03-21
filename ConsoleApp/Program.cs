using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, -21, 64, 59, 11, 0, -7, 53, -31, 1 };
            int[] numbers2 = { 11, 23, 60, 57, 62, 17, 42, 34, 123 };
            Task1.SelectNumberPositive(numbers);
            Task2.EvenNumbers(numbers2);

            string word = "automation";
            Console.WriteLine("Revers word  \"automation\":  " + Task3.Revers(word));

            Task4.ProcessNames();
            
            List<string> firstNames = new List<string> { "Igor", "Vasya", "Alex" };
            List<string> secondNames = new List<string> { "Nikita", "Yura", "Sergey" };
            Task5.DisplayFilteredAndReversedNames(firstNames, secondNames);

            List<string> names = new List<string> { "Brenda", "Kristina", "Anna", "Nik", "Hugo", "Alice", "Selena" };
            Task6.DisplaySortedNamesByLength(names);


            Product.ProcessProducts();


            Console.ReadLine();
        }

       

    }
}
