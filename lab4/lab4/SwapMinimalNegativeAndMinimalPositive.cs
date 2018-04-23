using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class SwapMinimalNegativeAndMinimalPositive
    {
        public int[] Swap(int[] array)
        {
            int minimalNegative = int.MaxValue;
            int minimalNegativeIndex = -1;
            int minimalPositive = int.MaxValue;
            int minimalPositiveIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && array[i] < minimalNegative)
                {
                    minimalNegative = array[i];  //поиск максимального по модулю отрицательного  числа 
                    minimalNegativeIndex = i;
                }
                else if (array[i] > 0 && array[i] < minimalPositive)
                {
                    minimalPositive = array[i];     //поиск максимального положительного числа
                    minimalPositiveIndex = i;
                }
            }


            if (minimalNegativeIndex != -1 && minimalPositiveIndex != -1)
            {
                int temp = array[minimalNegativeIndex];
                array[minimalNegativeIndex] = array[minimalPositiveIndex];
                array[minimalPositiveIndex] = temp;

            }


            return array;

        }
    }
}
