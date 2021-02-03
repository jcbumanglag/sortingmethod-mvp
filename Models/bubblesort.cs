using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class bubblesort
    {
        public char[] studs(char[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                for (int k = 0; k < v.Length - i - 1; k++)
                {
                    if (v[k] > v[k + 1])
                    {
                        char temp = v[k];
                        v[k] = v[k + 1];
                        v[k + 1] = temp;
                    }
                }
                
            }
            return v;
        } 
    }
}
