using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Insertion.STRATEGY
{
    public class InsertionSorter
    {
        private int operations = 0;
        private readonly ISortHandle sortHandle = null;
        public InsertionSorter(ISortHandle sortHandle)
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
                for (int indexNext = 0; indexNext < sortHandle.Length(); indexNext++)
                {
                    sortHandle.SetTemp(indexNext);
                    int index = indexNext;
                    while (sortHandle.IsSort(index))
                    {
                        sortHandle.Swap(index);
                        index--;
                        operations++;
                    }
                    sortHandle.SetArrayIndex(index);
                }
            }
        }
    }
}
