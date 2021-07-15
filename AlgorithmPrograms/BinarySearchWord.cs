using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    class BinarySearchWord<T> where T:IComparable
    {
        T[] array;
        public BinarySearchWord(T[] array)
        {
            this.array = array;
            Array.Sort(this.array);
        }
        public  int binarysearch(T[] array,T element)
        {
            int start = 0, end = array.Length - 1;
            while (start <= end)
            {
                int middle = start + (end - start) / 2;
                int res = element.CompareTo(array[middle]);
                if (res==0)
                    return middle;
                if (res>0)
                    start = middle + 1;
                else
                    end = middle - 1;
            }
            return -1;
        }
    }
}
         