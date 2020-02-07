using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice
{
    /// <summary>
    /// 選擇排序法
    /// </summary>
    public class ChoiceSorter
    {
        /// <summary>
        /// 陣列
        /// </summary>
        private int[] array;
        /// <summary>
        /// 陣列長度
        /// </summary>
        private int length;
        /// <summary>
        /// 交換次數
        /// </summary>
        private int operations;

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
        /// 操作次數
        /// </summary>
        public int Operations
        {
            get
            {
                return operations;
            }
        }
        /// <summary>
        /// 陣列長度
        /// </summary>
        public int Length
        {
            get
            {
                return length;
            }
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="array">陣列</param>
        public void Sort(int[] array)
        {
            this.array = array;
            this.length = array.Length;
            this.operations = 0;
            DoSort();
        }

        /// <summary>
        /// 做排序
        /// </summary>
        private void DoSort()
        {
            if (length > 1)
            {
                for (int indexNext = 0; indexNext < length - 1; indexNext++)
                {
                    int min = indexNext;
                    for (int index = indexNext + 1; index < length; index++)
                    {
                        if (array[index] < array[min])
                        {
                            min = index;
                            operations++;
                        }
                    }
                    int temp = array[min];
                    array[min] = array[indexNext];
                    array[indexNext] = temp;
                }

            }
        }
    }
}
