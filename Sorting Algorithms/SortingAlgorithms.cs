﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithms
{
    class SortingAlgorithms
    {
        // Prints out an array in format [ 0 1 2 ] and so forth
        public static void printArray(int[] arrayToPrint)
        {
            Console.Write("[ ");
            foreach (int i in arrayToPrint)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("]");
        }
        // Visually sorts an array of integers using the Bubble Sort algorithm
        public static void visualBubbleSort(int[] arrayToSort)
        {
            Console.Write("Starting array: ");
            printArray(arrayToSort);
            for (int i = 0; i + 1 < arrayToSort.Length; i++)
            {
                if (arrayToSort[i] > arrayToSort[i + 1])
                {
                    Console.Write($"Swapped {arrayToSort[i]} and {arrayToSort[i + 1]}: ");

                    int temp = arrayToSort[i + 1];
                    arrayToSort[i + 1] = arrayToSort[i];
                    arrayToSort[i] = temp;
                    i = -1;
                    printArray(arrayToSort);
                }
            }
            Console.Write("Sorted array: ");
            printArray(arrayToSort);

        }
        // Returns a sorted list, using the Bubble Sort algorithm
        public static int[] bubbleSort(int[] arrayToSort)
        {
            for (int i = 0; i + 1 < arrayToSort.Length; i++)
            {
                if (arrayToSort[i] > arrayToSort[i + 1])
                {
                    int temp = arrayToSort[i + 1];
                    arrayToSort[i + 1] = arrayToSort[i];
                    arrayToSort[i] = temp;
                    i = -1;
                }
            }
            return arrayToSort;
        }
    }
}
