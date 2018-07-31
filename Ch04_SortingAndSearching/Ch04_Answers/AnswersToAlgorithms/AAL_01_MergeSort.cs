using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    public class AAL_01_MergeSort
    {
        /// <summary>
        /// Calling function that will call the merge sort
        /// </summary>
        /// <param name="arr">input array to be sorted</param>
        public static void MergeSort(int[] arr)
        {
            MergeSortHelper(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Recursive function that will sort the array that was input by using the merging method.
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="low">starting index</param>
        /// <param name="high">ending index</param>
        private static void MergeSortHelper(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;

                MergeSortHelper(arr, low, middle);
                MergeSortHelper(arr, middle + 1, high);
                MergeHalves(arr, low, middle, high);
            }
        }

        /// <summary>
        /// Merges two halves of an array together simultaneously sorting the result array.
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="low">starting index</param>
        /// <param name="middle">middle index</param>
        /// <param name="high">ending index</param>
        private static void MergeHalves(int[] arr, int low, int middle, int high)
        {
            int[] tempArr = new int[arr.Length];
            int tempIndex = low;
            int lowEnd = middle;
            int highStart = middle + 1;
            int size = high - low + 1;

            // Take the minimum number between the left half and the right half of the specified indices and insert into the tempArr at the correct index
            while ((low <= lowEnd) && (highStart <= high))
            {
                if (arr[low] <= arr[highStart])
                {
                    tempArr[tempIndex++] = arr[low++];
                }
                if (arr[highStart] <= arr[low])
                {
                    tempArr[tempIndex++] = arr[highStart++];
                }
            }

            // Remaining items from the two halves will be inserted into the temporary array
            while (low <= lowEnd)
            {
                tempArr[tempIndex++] = arr[low++];
            }

            while (highStart <= high)
            {
                tempArr[tempIndex++] = arr[highStart++];
            }

            // Repopulate the original array with the temp array
            for (int i = 0; i < size; i++)
            {
                arr[high] = tempArr[high];
                high--;
            }
        }
    }
}
