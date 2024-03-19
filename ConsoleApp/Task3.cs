using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Task3
    {
//        Вывод слова в обратном порядке:
//•	У вас есть слово "automation".
//•	Напишите программу, чтобы вывести его буквы в обратном порядке(от последней к первой).

        
        public static string Revers(string input) 
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);

        }
    }
}
