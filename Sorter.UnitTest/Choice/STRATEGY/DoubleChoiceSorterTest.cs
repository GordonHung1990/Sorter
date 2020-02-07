using Sorter.Library.Choice.STRATEGY;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorter.UnitTest.Choice.STRATEGY
{
    /// <summary>
    /// Double - 選擇排序 - 測試
    /// </summary>
    [TestClass]
    public class DoubleChoiceSorterTest
    {
        private ChoiceSorter choiceSorter = null;
        private QuickChoiceSorter quickChoiceSorter = null;

        [TestInitialize]
        public void Start()
        {
            choiceSorter = new ChoiceSorter(new DoubleChoiceSorter());
            quickChoiceSorter = new QuickChoiceSorter(new DoubleChoiceSorter());
        }

        [TestMethod]
        public void TestSort()
        {
            Stopwatch sw = new Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            choiceSorter.DoSort(new double[] { 10.1, 9.1, 8.1, 7.1, 6.1, 5.1, 4.1, 3.1, 2.1, 1.1 });
            sw.Stop();//碼錶停止
            double sorterMilliseconds = sw.Elapsed.TotalMilliseconds;
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            quickChoiceSorter.DoSort(new double[] { 10.1, 9.1, 8.1, 7.1, 6.1, 5.1, 4.1, 3.1, 2.1, 1.1 });
            sw.Stop();//碼錶停止
            Assert.AreEqual(25, choiceSorter.Operations);
            Assert.AreEqual(25, quickChoiceSorter.Operations);
            //Assert.AreEqual(true, sw.Elapsed.TotalMilliseconds < sorterMilliseconds);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            choiceSorter.DoSort(new double[] { 1.1, 3.1, 2.1, 4.1, 5.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(1, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            choiceSorter.DoSort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(2, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            choiceSorter.DoSort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 9.1, 8.1, 10.1 });
            Assert.AreEqual(3, choiceSorter.Operations);
        }
    }
}
