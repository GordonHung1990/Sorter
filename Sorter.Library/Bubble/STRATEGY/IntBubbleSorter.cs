using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Bubble.STRATEGY
{
    public class IntBubbleSorter : ISortHandle
    {
        private int[] array = null;

        public bool IsSort(int index)
        {
            return (array[index] > array[index + 1]);
        }

        public int Length()
        {
            return array.Length;
        }

        public void SetArray(object array)
        {
            this.array = array as int[];
        }

        public void Swap(int index)
        {
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
