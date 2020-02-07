using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Bubble.TEMPLATE_METHOD
{
    /// <summary>
    /// 氣泡排序
    /// </summary>
    public abstract class BubbleSorter
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
            if (this.length > 1)
            {
                for (int indexNext = 1; indexNext < this.length; indexNext++)
                {
                    for (int index = 0; index < this.length - indexNext; index++)
                    {
                        if (IsSort(index))
                        {
                            Swap(index);
                            operations++;
                        }

                    }
                }
            }
        }
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index"></param>
        internal abstract void Swap(int index);
        /// <summary>
        /// 判斷順序
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        internal abstract bool IsSort(int index);
    }
}
