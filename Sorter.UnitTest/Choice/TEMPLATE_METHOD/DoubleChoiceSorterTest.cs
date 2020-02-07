using Sorter.Library.Choice.TEMPLATE_METHOD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.UnitTest.Choice.TEMPLATE_METHOD
{
    /// <summary>
    /// Double - 選擇排序 - 測試
    /// </summary>
    [TestClass]
    public class DoubleChoiceSorterTest
    {
        private DoubleChoiceSorter choiceSorter;

        [TestInitialize]
        public void Start()
        {
            choiceSorter = new DoubleChoiceSorter();
        }

        [TestMethod]
        public void TestSort()
        {
            choiceSorter.Sort(new double[] { 10.1, 9.1, 8.1, 7.1, 6.1, 5.1, 4.1, 3.1, 2.1, 1.1 });
            Assert.AreEqual(25, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            choiceSorter.Sort(new double[] { 1.1, 3.1, 2.1, 4.1, 5.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(1, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            choiceSorter.Sort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 8.1, 9.1, 10.1 });
            Assert.AreEqual(2, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            choiceSorter.Sort(new double[] { 1.1, 3.1, 2.1, 5.1, 4.1, 6.1, 7.1, 9.1, 8.1, 10.1 });
            Assert.AreEqual(3, choiceSorter.Operations);
        }
    }
}
