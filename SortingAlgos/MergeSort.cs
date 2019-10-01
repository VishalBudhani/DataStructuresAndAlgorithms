using System;
using System.Collections.Generic;
/// <summary>
/// Sample merge sort program using quick sort and non quick sort approach
/// </summary>
/// Written By Vishal Budhani Uploaded on 10/01/2019 12:49 EST
namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            List<int[]> list = GetDataToSort();

            for (int i=1; i<=list.Count; i++)
            {
                var array1 = list[i-1];
                Console.Write("Array# {0} before sorting is as: ", i);
                PrintArray(array1);

                Console.WriteLine("Performing Merge Sort without using quicksort to merge on the integer array");
                MergeSortWithoutQuickSort(ref array1, 0, array1.Length - 1);

                Console.Write("Array# {0} after sorting is as: ", i);
                PrintArray(array1);
            }

            Console.WriteLine("*********************************************************************************************************");

            
            list = GetDataToSort();

            for (int i = 1; i <= list.Count; i++)
            {
                var array1 = list[i - 1];
                Console.Write("Array# {0} before sorting is as: ", i);
                PrintArray(array1);

                Console.WriteLine("Performing Merge Sort using quicksort to merge on the integer array");
                MergeSortWithQuickSort(ref array1, 0, array1.Length - 1);

                Console.Write("Array# {0} after sorting is as: ", i);
                PrintArray(array1);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Creates input data
        /// </summary>
        /// <returns></returns>
        private static List<int[]> GetDataToSort()
        {
            int[] a1 = new int[] { 3, 9, 19, 92, 87, 67, 7, 87, 90, 96, 3, 7 };
            int[] a2 = new int[] { 32, 9, 19, 92, 8, 67, 67, 87, 90, 96, 3, 7, 999, 0, 35, 11 };
            int[] a3 = new int[] { 2 };
            int[] a4 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, -1, -2 };
            return new List<int[]> { a1, a2, a3, a4 };
        }

        private static void MergeSortWithoutQuickSort(ref int[] array1, int p, int r)
        {
            int q;
            if(p < r)
            {
                q = (p + r) / 2; //midpoint
                MergeSortWithoutQuickSort(ref array1, p, q);
                MergeSortWithoutQuickSort(ref array1, q + 1, r);
                MergeArraysWithoutQuickSort(ref array1, p, q, r); //Merging without quick sort approach

            }
        }

        private static void MergeSortWithQuickSort(ref int[] array1, int p, int r)
        {
            int q;
            if (p < r)
            {
                q = (p + r) / 2; //midpoint
                MergeSortWithQuickSort(ref array1, p, q);
                MergeSortWithQuickSort(ref array1, q + 1, r);
                MergeArraysWithQuickSort(ref array1, p, r); //Merging using quicksort approach

            }
        }

        /// <summary>
        /// Merging the arrays without quick sort approach
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="r"></param>
        private static void MergeArraysWithoutQuickSort(ref int[] array1, int p, int q, int r)
        {
            int[] tempArray = new int [array1.Length];
            int i = p;
            int j = q + 1;
            int k = 0;
            while(i <= q && j <= r)
            {
                tempArray[k++] = (array1[i] < array1[j]) ? array1[i++] : array1[j++];               
            }
            while (i <= q)
            {
                tempArray[k++] = array1[i++];
            }
            while (j <= r)
            {
                tempArray[k++] = array1[j++];
            }
            k = 0;
            for (i = p; i <= r; i++)
            {
                array1[i] = tempArray[k++];
            }
        }

        /// <summary>
        /// Merging the arrays using QuickSort approach
        /// </summary>
        /// <param name="array1">input array</param>
        /// <param name="p">starting index of the array items to merge</param>
        /// <param name="r">ending index of the array items to merge</param>
        private static void MergeArraysWithQuickSort(ref int[] array1, int p, int r)
        {
            if (p < r)
            {
                int q = GetPivotIndex(ref array1, p, r);
                MergeArraysWithQuickSort(ref array1, p, q-1);
                MergeArraysWithQuickSort(ref array1, q + 1, r);
            }
        }

        private static int GetPivotIndex(ref int[] array1, int p, int r)
        {
            int pivotData = array1[r];
            int i = p; // important initilaization
            int j = p; 
            for(j = p; j < r; j++)
            {
                if(array1[j] < pivotData)
                {
                    var temp = array1[i];
                    array1[i] = array1[j];
                    array1[j] = temp;
                    i++;
                }
            }
            array1[r] = array1[i];
            array1[i] = pivotData;
            return i;
        }

        /// <summary>
        /// Takes an integer array as input and prints all the items
        /// </summary>
        /// <param name="array1"></param>
        private static void PrintArray(int[] array1)
        {
            foreach(var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
