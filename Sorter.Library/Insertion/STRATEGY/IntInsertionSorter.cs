using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Insertion.STRATEGY
{
    public class IntInsertionSorter : ISortHandle
    {
        private int temp = 0;
        private int[] array = null;

        public bool IsSort(int index)
        {
            return (index > 0) && (array[index - 1] > temp);
        }

        public int Length()
        {
            return array.Length;
        }

        public void SetArray(object array)
        {
            this.array = array as int[];
        }

        public void SetArrayIndex(int index)
        {
            array[index] = temp;
        }

        public void SetTemp(int index)
        {
            temp = array[index];
        }

        public void Swap(int index)
        {
            array[index] = array[index - 1];
        }
    }
}
