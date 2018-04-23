using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходный массив чисел: ");
            List<int> array = new List<int> { 4, 5, 6, 7, -11, -3, 4, -5, -7, 2 };
            Console.WriteLine(string.Join(" ", array));
            Console.Write("Измененный массив:\n");

            InsertIntroArray inserter = new InsertIntroArray();
            List<int> result = inserter.Insert(array);
            Console.WriteLine();

            foreach (int element in result)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
        }
    }
}
