﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sorter.Library.Insertion.TEMPLATE_METHOD
{
    public class IntInsertionSorter : InsertionSorter
    {
        private int temp = 0;
        protected int[] array = null;

        public void Sort(int[] array)
        {
            this.array = array;
            this.length = array.Length;
            this.operations = 0;
            DoSort();
        }
        internal override bool IsSort(int index)
        {
            return (index > 0) && (array[index - 1] > temp);
        }

        internal override void SetArrayIndex(int index)
        {
            array[index] = temp;
        }

        internal override void SetTemp(int index)
        {
            temp = array[index];
        }

        internal override void Swap(int index)
        {
            array[index] = array[index - 1];
        }
    }
}
