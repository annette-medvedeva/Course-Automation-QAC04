using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Task5
    {
        //Объединение списков имен и фильтрация по предпоследней букве:
        //•	Даны два списка имен: `Igor, Vasya, Alex` и `Nikita, Yura, Sergey`.
        //•	Объедините эти списки в один и найдите в нём имена, которые не заканчиваются на букву "а".
        //•	Выведите их в обратном порядке.

        public static IEnumerable<string> FilterAndReverseNames(List<string> firstNames, List<string> secondNames)
        {
            var combinedNames = firstNames.Concat(secondNames);
            var filteredNames = combinedNames.Where(name => !name.EndsWith("a"));
            return filteredNames.Reverse();
        }

        public static void DisplayFilteredAndReversedNames(List<string> firstNames, List<string> secondNames)
        {
            var filteredAndReversedNames = FilterAndReverseNames(firstNames, secondNames);

            Console.WriteLine("Names not ending with 'a', in reverse order: ");
            foreach (var name in filteredAndReversedNames)
            {
                Console.WriteLine(name);
            }
        }

    }
}
