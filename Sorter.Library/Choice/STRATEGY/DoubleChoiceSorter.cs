using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice.STRATEGY
{
    /// <summary>
    /// Double - 選擇排序
    /// </summary>
    public class DoubleChoiceSorter : ISortHandle
    {
        private double[] array = null;

        public bool IsSort(int index, int min)
        {
            return array[index] < array[min];
        }

        public int Length()
        {
            return this.array.Length;
        }

        public void SetArray(object array)
        {
            this.array = array as double[];
        }

        public void Swap(int index, int min)
        {
            double temp = array[min];
            array[min] = array[index];
            array[index] = temp;
        }
    }
}
