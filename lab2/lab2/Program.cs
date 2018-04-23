using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Чем     примитивнее         человек, тем более   высокого        он о себе мнения.\n", temp;
            Console.WriteLine("Изначальная строка:");
            Console.WriteLine(str);
            WordSeparation wordsSeparator = new WordSeparation();
            string[] words = wordsSeparator.Separate(str);
            str = words.Aggregate((result, word) => result + " " + word);
            Console.WriteLine("Преобразованная строка:");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
