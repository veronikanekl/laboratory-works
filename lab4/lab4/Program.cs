using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 5, 6, 7, -12, -3, 4, -5, -7, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            SwapMinimalNegativeAndMinimalPositive Count = new SwapMinimalNegativeAndMinimalPositive();
            array = Count.Swap(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
