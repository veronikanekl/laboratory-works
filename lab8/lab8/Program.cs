using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;


            List<List<int>> array = new List<List<int>>();    //динамический двумерный массив
            List<int> row = new List<int>();                //строка массива
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                row = new List<int>();
                for (int j = 0; j < n; j++) row.Add(random.Next(-4, 7)); //строка массива заполняется просто суммой i и j
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


            InsertToArray method = new InsertToArray();
            List<List<int>> result = method.Insert(array);
            Console.WriteLine();

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result[i].Count; j++)
                {
                    Console.Write(string.Format("{0,4}", result[i][j]));
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
