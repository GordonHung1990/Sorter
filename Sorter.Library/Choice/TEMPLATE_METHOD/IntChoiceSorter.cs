using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice.TEMPLATE_METHOD
{
    public class IntChoiceSorter : ChoiceSorter
    {
        protected int[] array = null;
        public void Sort(int[] array)
        {
            this.array = array;
            this.length = array.Length;
            this.operations = 0;
            DoSort();
        }
        /// <summary>
        /// 陣列
        /// </summary>
        public int[] Array
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
            int temp = array[min];
            array[min] = array[index];
            array[index] = temp;
        }
    }
}
