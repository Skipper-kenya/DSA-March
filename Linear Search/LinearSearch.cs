using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA.Linear_Search
{
    public class LinearSearch
    {
       public int[] items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

       public bool LinearSearchFunc(int[] items , int key)
        {
            for(int i =0; i< items.Length;i++)
            {
                if (items[i] == key)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
