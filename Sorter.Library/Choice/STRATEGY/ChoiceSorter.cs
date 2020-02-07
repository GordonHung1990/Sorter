using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice.STRATEGY
{
    public class ChoiceSorter
    {
        private int operations = 0;
        private readonly ISortHandle sortHandle = null;
        public ChoiceSorter(ISortHandle sortHandle)
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
                for (int indexNext = 0; indexNext < sortHandle.Length() - 1; indexNext++)
                {
                    int min = indexNext;
                    for (int index = indexNext + 1; index < sortHandle.Length(); index++)
                    {
                        if (sortHandle.IsSort(index, min))
                        {
                            min = index;
                            operations++;
                        }
                    }
                    sortHandle.Swap(indexNext, min);
                }
            }
        }
    }
}
