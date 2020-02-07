using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice.STRATEGY
{
    /// <summary>
    /// 快速選擇排序
    /// </summary>
    public class QuickChoiceSorter
    {
        private int operations = 0;
        private int length = 0;
        private readonly ISortHandle sortHandle = null;
        public QuickChoiceSorter(ISortHandle sortHandle)
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
        /// 陣列長度
        /// </summary>
        public int Length
        {
            get
            {
                return sortHandle.Length();
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
                for (int indexNext = 0; indexNext < length - 1 && !PassInOrder; indexNext++)
                {
                    int min = indexNext;
                    PassInOrder = true;
                    for (int index = indexNext + 1; index < length; index++)
                    {
                        if (sortHandle.IsSort(index, min))
                        {
                            min = index;
                            operations++;
                            PassInOrder = false;
                        }
                    }
                    sortHandle.Swap(indexNext, min);
                }
            }
        }
    }
}
