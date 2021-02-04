using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting.Models
{
    public class sortmethod
    {
        public char[] inputstring { get; set; }
        
        public char[] SortingMethod()
        {
            SortedList records = new SortedList();
            records.Add(inputstring);

            records.SetSortStrategy(new QuickSort());
            records.Sort();

            records.SetSortStrategy(new MergeSort());

            records.Sort();
            
            return inputstring;
        }
       
      
    }

}
