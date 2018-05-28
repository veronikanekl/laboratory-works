using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab10
{
    class Remover
    {
        private List<int> array;
        public Remover(List<int> beginArray)
        {
            array = beginArray;
        }




        public List<int> Delete()
        {
            int temp = 0;
            for (int j = 0; j < array.Count; j++)
            {
                temp += array[j];
            }

            int middle = temp / array.Count;

            array.RemoveAll(i => i > middle);

            return array;
        }
    }
}
