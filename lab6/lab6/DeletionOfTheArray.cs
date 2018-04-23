using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class DeletionOfTheArray
    {
        public List<int> Delete(List<int> array)
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
