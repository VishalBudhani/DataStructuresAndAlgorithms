using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Written and owned by Vishal Budhani
/// </summary>
namespace InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            List<int[]> inputList = new List<int[]>();
            inputList.Add(new int[] { 34, 8, 99, 109, 3, 7, 4, 199, 88, 4, 1 });
            inputList.Add(new int[] { 101, 25, 12, 5, 2, 1 });
            inputList.Add(new int[] { });
            inputList.Add(new int[] { 1, 2, 3, 4, 5, 6 });

            for (int j = 0; j < inputList.Count; j++)
            {
                Console.WriteLine(string.Format("Array {0} before sorting is as: ", j + 1) +
                    PrintArray(inputList[j]));

                Console.WriteLine(string.Format("Array {0} after sorting is as: ", j + 1) +
                    PrintArray(PerformInsertionSort(inputList[j], j + 1)));
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        /// <summary>
        /// InsertionSort Implementation
        /// </summary>
        /// <param name="dataToSort"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static int[] PerformInsertionSort(int[] dataToSort, int index)
        {
            if (dataToSort == null || dataToSort.Count() == 0)
            {
                return dataToSort;
            }
            int dataLength = dataToSort.Length;
            for (int i = 1; i < dataLength; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (dataToSort[j] < dataToSort[j - 1])
                    {
                        var temp = dataToSort[j];
                        dataToSort[j] = dataToSort[j - 1];
                        dataToSort[j - 1] = temp;
                    }
                }
                Console.WriteLine("Array " + index + " after {0} pass is as: " + PrintArray(dataToSort), i);
            }

            return dataToSort;
        }
        /// <summary>
        /// Prints the contenst of the integer array
        /// </summary>
        /// <param name="dataToSort"></param>
        /// <returns></returns>
        private static string PrintArray(int[] dataToSort)
        {
            string result = string.Empty;
            if (dataToSort == null || dataToSort.Length == 0)
            {
                return "Nothing to sort, array is empty";
            }
            foreach (var item in dataToSort)
            {
                result += item + " ";
            }
            return result;
        }
    }
}
