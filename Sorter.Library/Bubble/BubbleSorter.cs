using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Bubble
{
    /// <summary>
    /// 氣泡排序法
    /// </summary>
    public class BubbleSorter
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
                return this.operations;
            }
        }

        /// <summary>
        /// 做排序
        /// </summary>
        private void DoSort()
        {
            if (this.length > 1)
            {
                for (int indexNext = 1; indexNext < this.length; indexNext++)
                {
                    for (int index = 0; index < this.length - indexNext; index++)
                    {
                        if (array[index] > array[index + 1])
                        {
                            int temp = array[index];
                            array[index] = array[index + 1];
                            array[index + 1] = temp;
                            operations++;
                        }

                    }
                }
            }
        }
    }
}
