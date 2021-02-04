using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    class QuickSort: Sortstrategy
    {
        public override void sort(List<char[]> list)
        {
            list.Sort();
        }
    }
}
