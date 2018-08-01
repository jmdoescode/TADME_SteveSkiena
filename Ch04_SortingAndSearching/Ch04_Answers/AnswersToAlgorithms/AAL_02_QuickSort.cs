using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    public static class AAL_02_QuickSort
    {

        /// <summary>
        /// Calling method to do a QuickSort
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Recursive function that will partition the array and sort both halves of the array until the entire array is sorted
        /// </summary>
        /// <param name="array">Array to be sorted</param>
        /// <param name="left">Left index</param>
        /// <param name="right">Right index</param>
        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int pivot = array[((left + right) / 2)]; // pick a random number to pivot
            int index = Partition(array, left, right, pivot); // returns the dividing point between left and right side as well as sorts the array
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }


        /// <summary>
        /// Left index increases until the number is greater than pivot and right index decreases until it is less than pivot and then numbers are swapped. This continues until all left side is less thand and all right side is greater than pivot point
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="pivot"></param>
        /// <returns></returns>
        public static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot) // move the index to the right if the value at left is still less than pivot
                    left++;

                while (array[right] > pivot) // move the index to the left if the value is still greater than the pivot
                    right--;

                if (left <= right)  // if the left index is still less than the right - swap the values at that index (increase left index and decrease right index)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }

            return left; // return the partition point
        }

        /// <summary>
        /// Swap values
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="left">Left index</param>
        /// <param name="right">Right Index</param>
        public static void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        /// <summary>
        /// Traverse the array to see what the answer is
        /// </summary>
        /// <param name="array"></param>
        public static void Traverse(int[] array)
        {
            foreach (int val in array)
                Console.Write(val + "->");

            Console.WriteLine();
        }
    }
}
