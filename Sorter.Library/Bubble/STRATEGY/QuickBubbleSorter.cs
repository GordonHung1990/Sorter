using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Bubble.STRATEGY
{
    /// <summary>
    /// 快速氣泡排序
    /// </summary>
    public class QuickBubbleSorter
    {
        private int operations = 0;
        private int length = 0;
        private readonly ISortHandle sortHandle = null;
        public QuickBubbleSorter(ISortHandle sortHandle)
        {
            this.sortHandle = sortHandle;
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
        /// 做排序
        /// </summary>
        /// <param name="array"></param>
        public void DoSort(object array)
        {
            sortHandle.SetArray(array);
            length = sortHandle.Length();
            operations = 0;
            if (length > 1)
            {
                bool PassInOrder = false;
                for (int indexNext = 1; indexNext < this.length && !PassInOrder; indexNext++)
                {
                    PassInOrder = true;
                    for (int index = 0; index < this.length - indexNext; index++)
                    {
                        if (sortHandle.IsSort(index))
                        {
                            sortHandle.Swap(index);
                            operations++;
                            PassInOrder = false;
                        }

                    }
                }
            }
        }
    }
}
