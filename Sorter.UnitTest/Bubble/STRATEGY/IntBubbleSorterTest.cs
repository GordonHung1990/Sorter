using Sorter.Library.Bubble.STRATEGY;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorter.UnitTest.Bubble.STRATEGY
{
    /// <summary>
    /// Int - 氣泡排序 - 測試
    /// </summary>
    [TestClass]
    public class IntBubbleSorterTest
    {
        private BubbleSorter bubbleSorter = null;
        private QuickBubbleSorter quickBubbleSorter = null;
        [TestInitialize]
        public void Start()
        {
            bubbleSorter = new BubbleSorter(new IntBubbleSorter());
            quickBubbleSorter = new QuickBubbleSorter(new IntBubbleSorter());
        }

        [TestMethod]
        public void TestSort()
        {
            Stopwatch sw = new Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            bubbleSorter.DoSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            sw.Stop();//碼錶停止
            double sorterMilliseconds = sw.Elapsed.TotalMilliseconds;
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            quickBubbleSorter.DoSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            sw.Stop();//碼錶停止
            Assert.AreEqual(45, bubbleSorter.Operations);
            Assert.AreEqual(45, quickBubbleSorter.Operations);
            //Assert.AreEqual(true, sw.Elapsed.TotalMilliseconds < sorterMilliseconds);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            bubbleSorter.DoSort(new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 });

            Assert.AreEqual(1, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            bubbleSorter.DoSort(new int[] { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            bubbleSorter.DoSort(new int[] { 1, 3, 2, 5, 4, 6, 7, 9, 8, 10 });
            Assert.AreEqual(3, bubbleSorter.Operations);
        }
    }
}
