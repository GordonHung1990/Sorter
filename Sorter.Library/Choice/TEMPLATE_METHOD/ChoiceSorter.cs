using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice.TEMPLATE_METHOD
{
    /// <summary>
    /// 選擇排序
    /// </summary>
    public abstract class ChoiceSorter
    {
        protected int operations = 0;
        protected int length = 0;

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
                return this.length;
            }
        }
        /// <summary>
        /// 做排序
        /// </summary>
        protected void DoSort()
        {
            if (length > 1)
            {
                for (int indexNext = 0; indexNext < length - 1; indexNext++)
                {
                    int min = indexNext;
                    for (int index = indexNext + 1; index < length; index++)
                    {
                        if (IsSort(index, min))
                        {
                            min = index;
                            operations++;
                        }
                    }
                    Swap(indexNext, min);
                }
            }
        }
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">最小索引值</param>
        internal abstract void Swap(int index, int minIndex);
        /// <summary>
        /// 判斷順序
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">最小索引值</param>
        /// <returns></returns>
        internal abstract bool IsSort(int index, int minIndex);
        
    }
}
