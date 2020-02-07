using Sorter.Library.Choice.STRATEGY;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorter.UnitTest.Choice.STRATEGY
{
    /// <summary>
    /// Int - 選擇排序 - 測試
    /// </summary>
    [TestClass]
    public class IntChoiceSorterTest
    {
        private ChoiceSorter choiceSorter = null;
        private QuickChoiceSorter quickChoiceSorter = null;

        [TestInitialize]
        public void Start()
        {
            choiceSorter = new ChoiceSorter(new IntChoiceSorter());
            quickChoiceSorter = new QuickChoiceSorter(new IntChoiceSorter());
        }

        [TestMethod]
        public void TestSort()
        {
            Stopwatch sw = new Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            choiceSorter.DoSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            sw.Stop();//碼錶停止
            double sorterMilliseconds = sw.Elapsed.TotalMilliseconds;
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            quickChoiceSorter.DoSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            sw.Stop();//碼錶停止
            Assert.AreEqual(25, choiceSorter.Operations);
            Assert.AreEqual(25, quickChoiceSorter.Operations);
            //Assert.AreEqual(true, sw.Elapsed.TotalMilliseconds < sorterMilliseconds);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            choiceSorter.DoSort(new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(1, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            choiceSorter.DoSort(new int[] { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            choiceSorter.DoSort(new int[] { 1, 3, 2, 5, 4, 6, 7, 9, 8, 10 });
            Assert.AreEqual(3, choiceSorter.Operations);
        }
    }
}
