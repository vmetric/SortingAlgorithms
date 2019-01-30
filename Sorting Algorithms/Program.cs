using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedIntArray = RandomArray.genIntList(10, 99).ToArray();
            Console.Write($"Unsorted, random array: ");
            SortingAlgorithms.printArray(unsortedIntArray);

            Console.WriteLine("Beginning bubble sort...");
            SortingAlgorithms.visualBubbleSort(unsortedIntArray);


            Console.ReadKey();
        }
    }
}
