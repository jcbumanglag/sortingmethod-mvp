using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sorting.Models;
using Sorting.Views;
namespace Sorting.Presenters
{
    public class sortmethodpresenter
    {
        Isortmethod sortmethodview;
        public sortmethodpresenter(Isortmethod view) 
        {
            sortmethodview = view;
        }

        public void sorting() 
        {
       
       sortmethod sortingmethod = new sortmethod();
        
       char[] newtextbox1 = sortmethodview.textbox1.ToCharArray();
        
       sortingmethod.inputstring = newtextbox1;

       sortmethodview.textres1 = String.Join(" ",sortingmethod.SortingMethod());
      



       
        
        
        }
    }
}
