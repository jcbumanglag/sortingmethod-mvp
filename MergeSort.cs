using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class MergeSort: Sortstrategy
    {
        public override void sort(List<char[]> list)
        {
            list.Sort();
        }
    }
}
