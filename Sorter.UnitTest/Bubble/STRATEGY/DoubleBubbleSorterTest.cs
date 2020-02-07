using Sorter.Library.Bubble.STRATEGY;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorter.UnitTest.Bubble.STRATEGY
{
    /// <summary>
    /// Double - 氣泡排序 - 測試
    /// </summary>
    [TestClass]
    public class DoubleBubbleSorterTest
    {
        private BubbleSorter bubbleSorter = null;
        private QuickBubbleSorter quickBubbleSorter = null;

        [TestInitialize]
        public void Start()
        {
            bubbleSorter = new BubbleSorter(new DoubleBubbleSorter());
            quickBubbleSorter = new QuickBubbleSorter(new DoubleBubbleSorter());
        }

        [TestMethod]
        public void TestSort()
        {
            Stopwatch sw = new Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            bubbleSorter.DoSort(new double[] { 10.1, 9.1, 8.1, 7.1, 6.1, 5.1, 4.1, 3.1, 2.1, 1.1 });
            sw.Stop();//碼錶停止
            double sorterMilliseconds = sw.Elapsed.TotalMilliseconds;
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            quickBubbleSorter.DoSort(new double[] { 10.1, 9.1, 8.1, 7.1, 6.1, 5.1, 4.1, 3.1, 2.1, 1.1 });
            sw.Stop();//碼錶停止
            Assert.AreEqual(45, bubbleSorter.Operations);
            Assert.AreEqual(45, quickBubbleSorter.Operations);
            //Assert.AreEqual(true, sw.Elapsed.TotalMilliseconds < sorterMilliseconds);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            bubbleSorter.DoSort(new double[] { 1.1, 3.1, 2.1, 4.1, 5.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(1, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            bubbleSorter.DoSort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(2, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            bubbleSorter.DoSort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 9.1, 8.1, 10.1 });
            Assert.AreEqual(3, bubbleSorter.Operations);
        }
    }
}
