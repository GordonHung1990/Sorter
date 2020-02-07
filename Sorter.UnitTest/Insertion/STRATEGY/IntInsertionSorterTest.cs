using Sorter.Library.Insertion.STRATEGY;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorter.UnitTest.Insertion.STRATEGY
{
    /// <summary>
    /// Int - 選擇排序 - 測試
    /// </summary>
    [TestClass]
    public class IntInsertionSorterTest
    {
        private InsertionSorter insertionSorter = null;

        [TestInitialize]
        public void Start()
        {
            insertionSorter = new InsertionSorter(new IntInsertionSorter());
        }

        [TestMethod]
        public void TestSort()
        {
            Stopwatch sw = new Stopwatch();//引用stopwatch物件
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時
            insertionSorter.DoSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            sw.Stop();//碼錶停止
            double sorterMilliseconds = sw.Elapsed.TotalMilliseconds;
            Assert.AreEqual(45, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestSort2()
        {
            insertionSorter.DoSort(new int[] { 1, 5, 3, 6, 10, 55, 9, 2, 87, 12, 34, 75, 33, 47 });
            Assert.AreEqual(21, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            insertionSorter.DoSort(new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(1, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            insertionSorter.DoSort(new int[] { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            insertionSorter.DoSort(new int[] { 1, 3, 2, 5, 4, 6, 7, 9, 8, 10 });
            Assert.AreEqual(3, insertionSorter.Operations);
        }
    }
}
