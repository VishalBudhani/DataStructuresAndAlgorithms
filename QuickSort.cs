using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// QuickSort Implementation
/// Written by Vishal Budhani
/// </summary>
namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            List<int[]> inputList = new List<int[]>();
            inputList.Add(new int[] { 3, 59, 78, 45, 3, 1, 2, 10, 11 });
            inputList.Add(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            inputList.Add(new int[] { 2, 3, 4, 5, 6 });
            inputList.Add(new int[] { 100, 5, 45, 9, 112, 555, 56 });
            inputList.Add(new int[] { 5, 3, 14 });
            inputList.Add(new int[] { });
            foreach (var item in inputList)
            {
                var arrayToSort = item;
                Console.WriteLine("Array before sorting is as: " + PrintArray(arrayToSort));

                new QuickSortImplementation().PerformQuickSort(ref arrayToSort, 0, arrayToSort.Length - 1);

                Console.WriteLine("Array after sorting is as: " + PrintArray(arrayToSort));
                Console.WriteLine();
            }

        }


        /// <summary>
        /// Prints the contents of the array.
        /// </summary>
        /// <param name="arrayToSort"></param>
        /// <returns></returns>
        private static string PrintArray(int[] arrayToSort)
        {
            string result = string.Empty;
            if (arrayToSort == null || arrayToSort.Count() == 0)
            {
                return "Nothing to sort";
            }
            else
            {
                foreach (var item in arrayToSort)
                {
                    result += item + " ";
                }
            }
            return result;
        }
    }

    /// <summary>
    /// Quick Sort Implementation
    /// </summary>
    public class QuickSortImplementation
    {
        int pivotIndex;
        public void PerformQuickSort(ref int[] arrayToSort, int low, int high)
        {
            if (low < high)
            {
                // Performing pivot opeartion and getting the pivot index
                pivotIndex = PerformPivotingOperation(ref arrayToSort, low, high);

                //Recursice calls to left of pivot index and right of pivot index
                PerformQuickSort(ref arrayToSort, low, pivotIndex - 1);
                PerformQuickSort(ref arrayToSort, pivotIndex + 1, high);
            }
            
        }
        /// <summary>
        /// Returns the pivot index to the caller
        /// </summary>
        /// <param name="arrayToSort"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        private int PerformPivotingOperation(ref int[] arrayToSort, int low, int high)
        {
            int pivot = arrayToSort[high];
            int i = low; // imp initialization
            for (int j = low; j < high; j++)
            {
                if (arrayToSort[j] < pivot)
                {
                    var temp = arrayToSort[j];
                    arrayToSort[j] = arrayToSort[i];
                    arrayToSort[i] = temp;
                    i++;
                }
            }
            arrayToSort[high] = arrayToSort[i];
            arrayToSort[i] = pivot;
            return i;
        }
    }
}
