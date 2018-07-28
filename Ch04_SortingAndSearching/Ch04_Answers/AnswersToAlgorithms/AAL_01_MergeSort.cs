using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04_Answers.AnswersToAlgorithms
{
    public class AAL_01_MergeSort
    {
        /// <summary>
        /// Calling function that will call the merge sort
        /// </summary>
        /// <param name="arr">The input array to be sorted</param>
        public static void MergeSort(int[] arr, bool progress)
        {
            MergeSort(arr, 0, arr.Length - 1, progress);
        }

        /// <summary>
        /// Recursive function that will sort the array that was input by using the merging method.
        /// </summary>
        /// <param name="inputArr">Array</param>
        /// <param name="leftStart">Start of the left side</param>
        /// <param name="rightEnd">End of the right side</param>
        public static void MergeSort(int[] inputArr, int leftStart, int rightEnd, bool progress)
        {
            if (rightEnd > leftStart)
            {
                int middle = (leftStart + rightEnd) / 2;

                MergeSort(inputArr, leftStart, middle, progress);
                MergeSort(inputArr, middle + 1, rightEnd, progress);
                MergeHalves(inputArr, leftStart, middle, rightEnd, progress);
            }
        }

        /// <summary>
        /// Merges two halves of an array together simultaneously sorting the result array.
        /// </summary>
        /// <param name="inputArr">Input Array</param>
        /// <param name="leftStart">Start of the array</param>
        /// <param name="middle">Middle of the array</param>
        /// <param name="rightEnd">End of the array</param>
        /// <param name="progress">Display the progress of the array?</param>
        private static void MergeHalves(int[] inputArr, int leftStart, int middle, int rightEnd, bool progress)
        {

            int size = rightEnd - leftStart + 1;
            int[] temp = new int[inputArr.Length];
            int tempIndex = leftStart;
            int leftEnd = middle;
            int rightStart = middle + 1;

            if(progress == true)
            {
                Console.WriteLine("-------------------------------------------------------------------------");
                Traverse(inputArr);
                Console.WriteLine($"Begin MergeHalves - leftStart: {leftStart} -- leftEnd: {leftEnd} -- rightStart: {rightStart} -- rightEnd: {rightEnd} -- size: {size}");
                Traverse(inputArr, leftStart, rightEnd);
            }            

            // Take the smaller of the numbers from the left half and right half and put it into the temporary array
            while ((leftStart <= leftEnd) && (rightStart <= rightEnd))
            {
                if (inputArr[leftStart] <= inputArr[rightStart])
                {
                    temp[tempIndex++] = inputArr[leftStart++];
                }
                else if (inputArr[rightStart] < inputArr[leftStart])
                {
                    temp[tempIndex++] = inputArr[rightStart++];
                }
            }

            // Remaining items from the two halves will be inserted into the temporary array
            while (leftStart <= leftEnd)
                temp[tempIndex++] = inputArr[leftStart++];

            while (rightStart <= rightEnd)
                temp[tempIndex++] = inputArr[rightStart++];

            if (progress == true)
            {
                Traverse(temp);
            }            

            // Repopulate the original array with the temp array
            for (int i = 0; i < size; i++)
            {
                inputArr[rightEnd] = temp[rightEnd];
                rightEnd--;
            }

            if (progress == true)
            {
                Console.WriteLine("MergeHalves");
                Traverse(inputArr);
            }
        }

        /// <summary>
        /// Traverse and print out the entire array
        /// </summary>
        /// <param name="arr">Input array</param>
        public static void Traverse(int[] arr)
        {
            foreach (int val in arr)
                Console.Write(string.Format("{0:n0}", val) + "->");

            Console.WriteLine("\n");
        }

        /// <summary>
        /// Traverse and print out the array choosing the beginning and ending
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <param name="begin">Beginning of the array</param>
        /// <param name="end">Ending of the array</param>
        public static void Traverse(int[] arr, int begin, int end)
        {
            for (int i = begin; i <= end; i++)
                Console.Write(string.Format("{0:n0}", arr[i]) + "->");

            Console.WriteLine("\n");
        }
    }
}
