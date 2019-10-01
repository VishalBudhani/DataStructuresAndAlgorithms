using System;
using System.Collections.Generic;

/// <summary>
/// Selection Sort Implementation 
/// </summary>
/// Written By Vishal Budhani Uploaded on 10/01/2019 16:07 EST
namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            List<int[]> dataList = new List<int[]>();
            dataList = GetInputData();

            Console.WriteLine("Sorting using selection sort approach");
            for (int i=1; i<=dataList.Count; i++)
            {
                Console.WriteLine(string.Format("Array #{0} before sorting is as: ", i+1) + PrintArray(dataList[i-1]));
                Console.WriteLine(string.Format("Array #{0} after complete sorting is as: ", i+1) + PrintArray(PerformSelectionSort(dataList[i-1])));
                Console.WriteLine("#################################################################################################");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Selection Sort Implementation
        /// </summary>
        /// <param name="arrayToSort"></param>
        /// <returns></returns>
        private static int[] PerformSelectionSort(int[] arrayToSort)
        {
            if(arrayToSort != null && arrayToSort.Length > 0)
            {
                int minIndex = -1;
                for(int i=0; i<arrayToSort.Length - 1; i++)
                {
                    for(int j = i+1; j< arrayToSort.Length; j++)
                    {
                        if(minIndex == -1 && (arrayToSort[j] < arrayToSort[i]))
                        {
                            minIndex = j;
                        }
                        else if (minIndex > 0 && (arrayToSort[j] < arrayToSort[minIndex]))
                        {
                            minIndex = j;
                        }
                    }
                    if(minIndex > 0)
                    {
                        //Swap the ith index item with the minimum index item using a temp variable
                        //Can be done with out a temp variable as well 
                        int temp = arrayToSort[minIndex];
                        arrayToSort[minIndex] = arrayToSort[i];
                        arrayToSort[i] = temp;
                     }
                    minIndex = -1; //reset the minIndex count to -1
                    Console.WriteLine(string.Format("Array after iteration# {0} is as: ", i+1) + PrintArray(arrayToSort));
                }
                return arrayToSort;
            }
            return arrayToSort;
        }

        /// <summary>
        /// Returns a string with the contents of the array based on the index
        /// </summary>
        /// <param name="arrayItems"></param>
        /// <returns></returns>
        private static string PrintArray(int[] arrayItems)
        {
            string result = string.Empty; 
            if(arrayItems != null && arrayItems.Length > 0)
            {
                foreach(var item in arrayItems)
                {
                    result += item + " ";
                }
            }
            return string.IsNullOrEmpty(result) ? "Nothing to sort, input array is empty" : result;
        }

        /// <summary>
        /// Creates the input arrays for sorting
        /// </summary>
        /// <returns></returns>
        private static List<int[]> GetInputData()
        {
            var data = new List<int[]>();
            data.Add(new int[] { 55, 78, 7, 8, 9, 9, 19, 1, -1, -30, 99, 78, 100, 999 });
            data.Add(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 8, 9, 18 });
            data.Add(new int[] { 8, 9, 10, 11, 12 });
            data.Add(new int[] { });
            return data;
        }
    }
}
