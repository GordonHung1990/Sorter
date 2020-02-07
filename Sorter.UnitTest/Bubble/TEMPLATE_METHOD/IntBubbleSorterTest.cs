using Sorter.Library.Bubble.TEMPLATE_METHOD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.UnitTest.Bubble.TEMPLATE_METHOD
{
    /// <summary>
    /// Int - 氣泡排序 - 測試
    /// </summary>
    [TestClass]
    public class IntBubbleSorterTest
    {
        private IntBubbleSorter bubbleSorter;

        [TestInitialize]
        public void Start()
        {
            bubbleSorter = new IntBubbleSorter();
        }

        [TestMethod]
        public void TestSort()
        {
            bubbleSorter.Sort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            Assert.AreEqual(45, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            bubbleSorter.Sort(new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 });

            Assert.AreEqual(1, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            bubbleSorter.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            bubbleSorter.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 9, 8, 10 });
            Assert.AreEqual(3, bubbleSorter.Operations);
        }
    }
}
