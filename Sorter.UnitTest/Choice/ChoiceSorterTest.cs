using Sorter.Library.Choice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.UnitTest.Choice
{
    [TestClass]
    public class ChoiceSorterTest
    {
        private ChoiceSorter choiceSorter = null;

        [TestInitialize]
        public void Start()
        {
            choiceSorter = new ChoiceSorter();
        }

        [TestMethod]
        public void TestSort()
        {
            choiceSorter.Sort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            Assert.AreEqual(25, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            choiceSorter.Sort(new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(1, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            choiceSorter.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2, choiceSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            choiceSorter.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 9, 8, 10 });
            Assert.AreEqual(3, choiceSorter.Operations);
        }
    }
}
