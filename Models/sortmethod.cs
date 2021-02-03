using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting.Models
{
    public class sortmethod
    {
        public char[] inputstring { get; set; }
        
        public char[] bubsort()
        {
            for (int i = 0; i < inputstring.Length - 1; i++)
            {
                for (int k = 0; k < inputstring.Length - i - 1; k++)
                {
                    if (inputstring[k] > inputstring[k + 1])
                    {
                        char temp = inputstring[k];
                        inputstring[k] = inputstring[k + 1];
                        inputstring[k + 1] = temp;
                    }
                }

            }
            return inputstring;
        }
       
      
    }

}
