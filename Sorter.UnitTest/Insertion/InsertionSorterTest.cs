﻿using Sorter.Library.Insertion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.UnitTest.Insertion
{
    [TestClass]
    public class InsertionSorterTest
    {
        private InsertionSorter insertionSorter = null;

        [TestInitialize]
        public void Start()
        {
            insertionSorter = new InsertionSorter();
        }

        [TestMethod]
        public void TestSort()
        {
            insertionSorter.Sort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            Assert.AreEqual(45, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestSort2()
        {
            insertionSorter.Sort(new int[] { 1, 5, 3, 6, 10, 55, 9, 2, 87, 12, 34, 75, 33, 47 });
            Assert.AreEqual(21, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestOneSorter()
        {
            insertionSorter.Sort(new int[] { 1, 3, 2, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(1, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestTwoSorter()
        {
            insertionSorter.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2, insertionSorter.Operations);
        }
        [TestMethod]
        public void TestThreeSorter()
        {
            insertionSorter.Sort(new int[] { 1, 3, 2, 5, 4, 6, 7, 9, 8, 10 });
            Assert.AreEqual(3, insertionSorter.Operations);
        }
    }
}
