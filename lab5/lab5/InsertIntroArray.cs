using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class InsertIntroArray
    {
        public List<int> Insert(List<int> array)
        {
            int sum = Math.Abs(array[0]) + Math.Abs(array[1]) + Math.Abs(array[array.Count - 1]);

            for (int i = 0; i < array.Count; ++i)
            {
                if (sum % array[i] == 0)
                {
                    array.Insert(++i, 0);
                }
            }

            return array;
        }
    }
}
