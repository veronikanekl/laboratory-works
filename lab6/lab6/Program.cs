using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходный массив чисел: ");
            List<int> array = new List<int> { 4, 5, 6, -4, -5, -12, -34, 3, 4 };
            Console.WriteLine(string.Join(" ", array));

            Console.Write("Измененный массив:\n");
            DeletionOfTheArray operation = new DeletionOfTheArray();
            List<int> result = operation.Delete(array);
            Console.WriteLine(string.Join(" ", array));

            Console.ReadKey();
        }
    }
}
