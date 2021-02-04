using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sorting.Models;
namespace Sorting
{
    class SortedList
    {
        private List<char[]> _list = new List<char[]>();
        private Sortstrategy _sortstrategy;

        public void SetSortStrategy(Sortstrategy sortstrategy) 
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(char[] alpha) 
        {
            _list.Add(alpha);
        }
        public void Sort() 
        {
            _sortstrategy.sort(_list);
            foreach (char[] alpha in _list) 
            {
                sortmethod n = new sortmethod();
                n.inputstring = alpha;
              
        
            }
        }
    }
}
