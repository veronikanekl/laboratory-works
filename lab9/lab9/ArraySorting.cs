using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab9
{
    class ArraySorting
    {
        public List<List<int>> Sorting(List<List<int>> array)
        {
            List<int> t = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++) t.Add(array[i][j]);
                t = t.OrderByDescending(x => x).ToList();
                for (int j = 0; j < array.Count; j++) array[i][j] = t[j];
                t.Clear();
            }

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++) t.Add(array[j][i]);
                t = t.OrderByDescending(x => x).ToList();
                for (int j = 0; j < array.Count; j++) array[j][i] = t[j];
                t.Clear();
            }
            return array;
        }
    }
}
