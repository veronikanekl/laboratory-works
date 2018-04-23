using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[,] array = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(100);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }


            Permutation Transfer = new Permutation();
            (int count, int sum) = Transfer.Approach(array);
            Console.WriteLine("\nКоличество элементов, больших среднего арифметического, находящихся над главной диагональю: {0}", count);
            Console.WriteLine("\nСумма элементов, больших среднего арифметического, находящихся под главной диагональю: {0}", sum);

            Console.Read();
        }
    }
}
