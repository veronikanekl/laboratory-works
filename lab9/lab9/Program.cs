using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Упорядочить элементы в матрице по убыванию(слева направо,сверху вниз) \n");
            int n = 4;
            List<List<int>> array = new List<List<int>>();    //динамический двумерный массив
            List<int> row = new List<int>();                //строка массива
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                row = new List<int>();
                for (int j = 0; j < n; j++) row.Add(random.Next(-3, 7));
                array.Add(row);                               //строка добавляется в массив
            }

            for (int i = 0; i < n; i++)                     //вывод массива
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format("{0,4}", array[i][j]));
                }

                Console.WriteLine();
            }

            ArraySorting method = new ArraySorting();
            List<List<int>> result = method.Sorting(array);
            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(string.Format("{0,4}", result[i][j]));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
