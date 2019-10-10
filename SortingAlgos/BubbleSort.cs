using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Written by Vishal Budhani
/// </summary>
namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            List<int[]> inputList = new List<int[]>();
            inputList.Add(new int[] { 3, 59, 78, 45, 3, 1, 2, 10, 11 });
            inputList.Add(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            inputList.Add(new int[] { 2, 3, 4, 5, 6 });
            inputList.Add(new int[] { 100, 5, 45, 9, 112, 555, 56 });
            inputList.Add(new int[] { 5, 3, 14 });
            inputList.Add(new int[] { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 90});
            for(int i=0; i<inputList.Count; i++)
            {
                var arrayToSort = inputList[i];
                Console.WriteLine("Array {0} before sorting is as: " + PrintArray(arrayToSort), i+1);

                Console.WriteLine("Array after sorting is as: " + PrintArray(BubbleSortImplementation(arrayToSort, i+1)));
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Bubble Sort Implementation
        /// </summary>
        /// <param name="dataToSort"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private static int[] BubbleSortImplementation(int[] dataToSort, int count)
        {
            if(dataToSort == null || dataToSort.Count() == 0)
            {
                return dataToSort;
            }

            int itemCount = dataToSort.Count();
            bool canLoop = true;
            int innerCount = itemCount -1; 
            for(int i=0; i<itemCount && canLoop; i++) // can loop is false means array is sorted
            {
                canLoop = false;
                int k = 0;
                for(int j = innerCount; j > 0; j--)
                {
                    if(dataToSort[k] > dataToSort[k+1])
                    {
                        var temp = dataToSort[k+1];
                        dataToSort[k+1] = dataToSort[k];
                        dataToSort[k] = temp;
                        canLoop = true;
                    }
                    k++;
                }
                Console.WriteLine("Array {0} after pass #{1} is as: " + PrintArray(dataToSort), count, i + 1);
            }
            return dataToSort;
        }

        /// <summary>
        /// Print Array contents
        /// </summary>
        /// <param name="dataToSort"></param>
        /// <returns></returns>
        private static string PrintArray(int[] dataToSort)
        {
            string result = string.Empty;
            foreach (var item in dataToSort)
            {
                result += item + " ";
            }
            return result;
        }
    }
}
