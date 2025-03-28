using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA.Arrays
{
    public class Arrays
    {
        public void InsertAtEndOfArray(int value)
        {
            int[] intArray = new int[6];

            int length = 0;

            //filling in the values of the array

            for (int i = 0; i < 4; i++) { 
                intArray[length] = i +1;
                length++;
            }

            //inserting a new value at the end of the array

            intArray[length] = value;
            length++;

            int val = 0; //dummy  variable to enable watch over the 20 insertion
        }


        public void InsertAtStartOfArray(int value) {
            int[] intArray = new int[10];

            int length = 0;

            //filling in the values of the array

            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            //inserting a new value at the start of the array

            for(int i = 6; i >= 0; i--)
            {
                //shifting the elements to the right
                intArray[i +1] = intArray[i];
            }


            intArray[0] = value;
            int val = 0;

        }


        public void InsertAnywhereInArray() {
            int[] intArray = new int[10];

            int length = 0;

            //filling in the values of the array

            for (int i = 0; i < 6; i++)
            {
                intArray[length] = i + 1;
                length++;
            }

            //inserting a new value at the (stated in param) index of the array
            for(int i = 6; i>= 2; i--)
            {
                intArray[i+1] = intArray[i];
            }

            intArray[2] = 20;
            int val = 0;

        }
    } }
