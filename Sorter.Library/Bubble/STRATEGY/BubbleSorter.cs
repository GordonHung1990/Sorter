using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Bubble.STRATEGY
{
    /// <summary>
    /// 氣泡排序
    /// </summary>
    public class BubbleSorter
    {
        private int operations = 0;
        private readonly ISortHandle sortHandle = null;
        public BubbleSorter(ISortHandle sortHandle)
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
                return this.operations;
            }
        }

        /// <summary>
        /// 做排序
        /// </summary>
        /// <param name="array"></param>
        public void DoSort(object array)
        {
            sortHandle.SetArray(array);

            operations = 0;
            if (sortHandle.Length() > 1)
            {
                for (int indexNext = 1; indexNext < sortHandle.Length(); indexNext++)
                {
                    for (int index = 0; index < sortHandle.Length() - indexNext; index++)
                    {
                        if (sortHandle.IsSort(index))
                        {
                            sortHandle.Swap(index);
                            operations++;
                        }

                    }
                }
            }
        }
    }
}
