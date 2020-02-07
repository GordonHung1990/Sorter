using Sorter.Library.Choice.TEMPLATE_METHOD;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.UnitTest.Choice.TEMPLATE_METHOD
{
    /// <summary>
    /// Int - 選擇排序 - 測試
    /// </summary>
    [TestClass]
    public class IntChoiceSorterTest
    {
        private IntChoiceSorter ChoiceSort = null;

        [TestInitialize]
        public void Start()
        {
            ChoiceSort = new IntChoiceSorter();
        }

        [TestMethod]
        public void TestSort()
        {
            ChoiceSort.Sort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            Assert.AreEqual(25, ChoiceSort.Operations);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            ChoiceSort.Sort(new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(1, ChoiceSort.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            ChoiceSort.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2, ChoiceSort.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            ChoiceSort.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 9, 8, 10 });
            Assert.AreEqual(3, ChoiceSort.Operations);
        }
    }
}
