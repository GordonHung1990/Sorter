using Sorter.Library.Bubble.TEMPLATE_METHOD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.UnitTest.Bubble.TEMPLATE_METHOD
{
    /// <summary>
    /// Double - 氣泡排序 - 測試
    /// </summary>
    [TestClass]
    public class DoubleBubbleSorterTest
    {
        private DoubleBubbleSorter bubbleSorter;

        [TestInitialize]
        public void Start()
        {
            bubbleSorter = new DoubleBubbleSorter();
        }

        [TestMethod]
        public void TestSort()
        {
            bubbleSorter.Sort(new double[] { 10.1, 9.1, 8.1, 7.1, 6.1, 5.1, 4.1, 3.1, 2.1, 1.1 });
            Assert.AreEqual(45, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            bubbleSorter.Sort(new double[] { 1.1, 3.1, 2.1, 4.1, 5.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(1, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            bubbleSorter.Sort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(2, bubbleSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            bubbleSorter.Sort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 9.1, 8.1, 10.1 });
            Assert.AreEqual(3, bubbleSorter.Operations);
        }
    }
}
