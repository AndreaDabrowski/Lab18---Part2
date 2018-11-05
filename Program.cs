using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab18Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*first part Big O estimate is O(n) because it's linear */
            int _0counter = 0;
            int _1counter = 0;
            int _2counter = 0;
            int _3counter = 0;
            int _4counter = 0;
            int _5counter = 0;
            int _6counter = 0;
            int _7counter = 0;
            int _8counter = 0;
            int _9counter = 0;
            int _10counter = 0;


            int[] intArray = new int[] { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            foreach (int num in intArray)
            {
                if (num == 0)
                {
                    _0counter++;
                }
                else if (num == 1)
                {
                    _1counter++;
                }
                else if (num == 2)
                {
                    _2counter++;
                }
                else if (num == 3)
                {
                    _3counter++;
                }
                else if (num == 4)
                {
                    _4counter++;
                }
                else if (num == 5)
                {
                    _5counter++;
                }
                else if (num == 6)
                {
                    _6counter++;
                }
                else if (num == 7)
                {
                    _7counter++;
                }
                else if (num == 8)
                {
                    _8counter++;
                }
                else if (num == 9)
                {
                    _9counter++;
                }
                else if (num == 10)
                {
                    _10counter++;
                }
            }
            Console.WriteLine("[0]: {0}, [1]: {1}, [2]: {2}, [3]: {3}, [4]: {4}, [5]: {5}, [6]: {6}, [7]: {7}, [8]: {8}, [9]: {9}, [10]: {10}", _0counter, _1counter, _2counter, _3counter, _4counter, _5counter, _6counter, _7counter, _8counter, _9counter, _10counter);

            //Array Algorithm
            //1. initialize array of 15 integer values (ints between 1-10)
            //2. Sort array
            //3.cycle through array with for loop (j)
            //4. cycle through integers between 1 - 10 with for loop (i)
            //5. if the element at array[j] is == to the element at array[j+1], increase count
            //6.display that count to user ([i]: count)
            //7.continue steps 4 and 5 until end of array is reached


            //HashTable Algorithm
            //1. initialize array of 15 integer values (ints between 1-10)
            //2.Sort array (optional)
            //3.initialize hashtable (ht)
            //4.cycle through values of array and add to hashtable using for loop
            //5.for loop to return values 1-10 (i)
            //6.if hashtable does not contain value (i), return count of zero ([i]: 0)
            //7.if ht.containsvalue (i), count++
            //8.get key of this value
            //9.remove value from hashtable using key
            //10.continue steps 4-7 until ht does not ContainValue(i), display to user ([i]: count), and move on to next ht.containsValue(i+1)
            
        }
    }
}
