using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8
{
    class InsertToArray
    {
        public List<List<int>> Insert(List<List<int>> array)
        {


            List<int> summ = new List<int>();
            int sum = 0;

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[i][j] < 0)
                    {
                        sum += array[i][j];
                        // array[i].Insert(j++, summ[i]);
                    }
                }
                summ.Add(sum);
                sum = 0;
                //Console.Write("{0}" + " ", summ[i]);
            }
            for (int i = 0; i < array.Count; i++)
            {
                array[i].Add(summ[i]);
            }



            return array;
        }
    }
}
