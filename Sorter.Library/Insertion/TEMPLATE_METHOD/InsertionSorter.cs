using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Insertion.TEMPLATE_METHOD
{
    public abstract class InsertionSorter
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
                for (int indexNext = 0; indexNext < length; indexNext++)
                {
                    SetTemp(indexNext);
                    int index = indexNext;
                    while (IsSort(index))
                    {
                        Swap(index);
                        index--;
                        operations++;
                    }
                    SetArrayIndex(index);
                }
            }
        }
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">最小索引值</param>
        internal abstract void Swap(int index);
        /// <summary>
        /// 判斷順序
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">暫存值</param>
        /// <returns></returns>
        internal abstract bool IsSort(int index);
        /// <summary>
        /// 設定暫存
        /// </summary>
        /// <param name="index"></param>
        internal abstract void SetTemp(int index);
        /// <summary>
        /// 設定暫存
        /// </summary>
        /// <param name="index"></param>
        internal abstract void SetArrayIndex(int index);
    }
}
