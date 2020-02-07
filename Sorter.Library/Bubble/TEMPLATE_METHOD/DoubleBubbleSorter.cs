using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Bubble.TEMPLATE_METHOD
{
    public class DoubleBubbleSorter : BubbleSorter
    {
        protected double[] array = null;

        public void Sort(double[] array)
        {
            this.array = array;
            this.length = array.Length;
            this.operations = 0;
            DoSort();
        }

        /// <summary>
        /// 陣列
        /// </summary>
        public double[] Array
        {
            get
            {
                return this.array;
            }
        }

        internal override bool IsSort(int index)
        {
            return (array[index] > array[index + 1]);
        }

        internal override void Swap(int index)
        {
            double temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
