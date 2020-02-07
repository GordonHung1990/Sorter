using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Choice.STRATEGY
{
    public interface ISortHandle
    {
        /// <summary>
        /// 交換
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">最小索引值</param>
        void Swap(int index, int min);
        /// <summary>
        /// 判斷順序
        /// </summary>
        /// <param name="index">索引值</param>
        /// <param name="minIndex">最小索引值</param>
        /// <returns></returns>
        bool IsSort(int index, int min);
        /// <summary>
        /// 長度
        /// </summary>
        /// <returns></returns>
        int Length();
        /// <summary>
        /// 設定陣列
        /// </summary>
        /// <param name="array"></param>
        void SetArray(object array);
    }
}
