using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class RandomArray
    {
        //Generates a list of integers of a given size, with a given max integer value
        public static List<int> genIntList(int size, int maxInt)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(new Random().Next(maxInt));
            }

            return list;
        }


    }
}
