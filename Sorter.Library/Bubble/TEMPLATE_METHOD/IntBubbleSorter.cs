using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Bubble.TEMPLATE_METHOD
{
    public class IntBubbleSorter : BubbleSorter
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
        /// <returns></returns>
        internal override bool IsSort(int index)
        {
            return (array[index] > array[index + 1]);
        }
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index"></param>
        internal override void Swap(int index)
        {
            int temp = array[index];
            array[index] = array[index + 1];
            array[index + 1] = temp;
        }
    }
}
