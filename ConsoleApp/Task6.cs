using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task6
    {
//  Сортировка имен по длине:
//•	У вас есть список имен: `Brenda, Kristina, Anna, Nik, Hugo, Alice, Selena`.
//•	Отсортируйте список по возрастанию количества букв в каждом имени.
//•	Для каждого имени в отсортированном списке, выведите в консоль количество символов.

        public static void DisplaySortedNamesByLength(List<string> names)
        {
            var sortedNames = names.OrderBy(name => name.Length);

            Console.WriteLine("Sorted list of names by length: ");

            foreach (var name in sortedNames)
            {
                Console.WriteLine($"{name} ({name.Length} symbols)");
            }
        }
    }
}
