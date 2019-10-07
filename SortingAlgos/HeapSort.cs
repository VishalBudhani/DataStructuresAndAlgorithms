using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class HeapSort
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

                // The last parent node will always be at the index (arrayToSort.Length / 2) - 1
                Heapify(ref arrayToSort, (arrayToSort.Length / 2) - 1, 0, arrayToSort.Length);
                for(int i= arrayToSort.Length -1; i>0; i--)
                {
                    //Swap 1st and last item and then Heapify
                    arrayToSort[0] = arrayToSort[0] + arrayToSort[i];
                    arrayToSort[i] = arrayToSort[0] - arrayToSort[i];
                    arrayToSort[0] = arrayToSort[0] - arrayToSort[i];
                    //Swaping of 1st and last element completed here

                    Heapify(ref arrayToSort, (i/ 2) - 1, 0, i);
                }

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
            if(arrayToSort == null || arrayToSort.Count() == 0)
            {
                return "Nothing to sort";
            }
            else
            {
                foreach(var item in arrayToSort)
                {
                    result += item + " ";
                }
            }
            return result;
        }

        /// <summary>
        /// Heapify Method which heapifies 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="maxParentIndex"></param>
        /// <param name="minParentIndex"></param>
        /// <param name="maxLength"></param>
        private static void Heapify(ref int[] v, int maxParentIndex, int minParentIndex, int maxLength)
        {
            try
            {
                if(maxParentIndex >= minParentIndex)
                {
                    for (int i = maxParentIndex; i >= minParentIndex; i--)
                    {
                        int leftChildIndex = (((i * 2) + 1) <= maxLength - 1) ? (i * 2) + 1 : -1;
                        int rightChildIndex = (((i * 2) + 2) <= maxLength - 1) ? (i * 2) + 2 : -1;

                        #region Check if parent node is smaller than the child nodes
                        if (leftChildIndex != -1 && rightChildIndex != -1)
                        {
                            if (!(v[i] > v[leftChildIndex] && v[i] > v[rightChildIndex]))
                            {
                                int index = (v[leftChildIndex] > v[rightChildIndex]) ? 
                                    leftChildIndex : rightChildIndex;
                                v[i] = v[i] + v[index];
                                v[index] = v[i] - v[index];
                                v[i] = v[i] - v[index];
                            }
                        }
                        else
                        {
                            if (v[i] < v[leftChildIndex])
                            {
                                v[i] = v[i] + v[leftChildIndex];
                                v[leftChildIndex] = v[i] - v[leftChildIndex];
                                v[i] = v[i] - v[leftChildIndex];
                            }
                        }
                        #endregion Check if parent node is smaller than the child nodes

                        #region Heapify Method
                        if ((maxLength / 2) - 1 > i)
                        {
                            // The commented code below is the optimized heapify code.
                            //int j = maxParentIndex;
                            //while (j < (i + 1))
                            //{
                            //    if (j == (2 * i + 1) || j == (2 * i + 2))
                            //    {
                            //        Heapify(ref v, j, i + 1, maxLength);
                            //    }
                            //    j--;
                            //}

                            // Non optimized Heapify method, comment this code and uncomment above to get fatser results.
                            Heapify(ref v, (maxLength / 2) - 1, i + 1, maxLength);
                        }
                        #endregion Heapify code ends here
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
