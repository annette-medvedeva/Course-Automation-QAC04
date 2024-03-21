using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Task4
    {
        //        Изменение первой буквы в именах:
        //Вы имеете список имен: `Alexa, Kirill, Jonas, Alina, Andrey, Danila, Nick, Amer, Chastity, Khristina, Amelia`.
        //Найдите все имена, которые начинаются на букву "A".
        //Измените первую букву в этих именах на "I" и сформируйте новый список.
        //Выведите изменённый список имен в консоль.

        public static List<string> ModifyNames(List<string> names)
        {
            var namesStartingWithA = names.Where(name => name.StartsWith("A"));
            var modifiedNames = namesStartingWithA.Select(name => "I" + name.Substring(1)).ToList();
            return modifiedNames;
        }
        public static void ProcessNames()
        {
            List<string> names = new List<string> { "Alexa", "Kirill", "Jonas", "Alina", "Andrey", "Danila", "Nick", "Amer", "Chastity", "Khristina", "Amelia" };
            var modifiedNames = ModifyNames(names);
            Console.WriteLine("List of names with the first letter changed:");
            foreach (var name in modifiedNames)
            {
                Console.WriteLine(name);
            }
        }

    }
}
