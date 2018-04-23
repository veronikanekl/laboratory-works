using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Permutation
    {
        public (int, int) Approach(int[,] array)
        {
            int count = 0;
            int sum = 0;
            int middle = 0;
            int arraySum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arraySum += array[i, j];
                }
            }

            middle = arraySum / (array.GetLength(0) * array.GetLength(1));
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i > j && array[i, j] > middle)
                    {
                        count++;
                    }
                    if (j >= array.GetLength(0) - i && array[i, j] > middle)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return (count, sum);
        }
    }
}
