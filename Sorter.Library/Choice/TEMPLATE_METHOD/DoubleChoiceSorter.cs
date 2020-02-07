using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice.TEMPLATE_METHOD
{
    public class DoubleChoiceSorter : ChoiceSorter
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
        /// <summary>
        /// 判斷順序
        /// </summary>
        /// <param name="index"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        internal override bool IsSort(int index, int min)
        {
            return array[index] < array[min];
        }
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index"></param>
        /// <param name="min"></param>
        internal override void Swap(int index, int min)
        {
            double temp = array[min];
            array[min] = array[index];
            array[index] = temp;
        }
    }
}
