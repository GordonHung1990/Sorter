using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Insertion.STRATEGY
{
    public interface ISortHandle
    {
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">最小索引值</param>
        void Swap(int index);
        /// <summary>
        /// 判斷順序
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">暫存值</param>
        /// <returns></returns>
        bool IsSort(int index);
        /// <summary>
        /// 設定暫存
        /// </summary>
        /// <param name="index"></param>
        void SetTemp(int index);
        int Length();

        /// <summary>
        /// 設定暫存
        /// </summary>
        /// <param name="index"></param>
        void SetArrayIndex(int index);
        void SetArray(object array);
    }
}
