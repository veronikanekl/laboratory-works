using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 1, 2, 3, 3, 4, 5, 5, 6, 7, 7, 8, 9, 9, 9, 11 };
            
            int count = 1;
            int number = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] == number)
                    count++;
                else
                {
                    Console.Write(count + " ");
                    count = 1;
                    number = mas[i];
                }
            }
            Console.Write(count + " ");
            Console.ReadKey();
        }
    }
}
