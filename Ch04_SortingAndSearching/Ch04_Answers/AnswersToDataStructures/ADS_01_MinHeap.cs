using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    /// <summary>
    /// Min Heap which will have the minimum number from top to bottom. An item at a higher level will alway be less than the number below it.
    /// </summary>
    public class ADS_01_MinHeap
    {
        private static int capacity = 10;
        private static int size = 0;
        private static int[] items = new int[capacity];

        // Methods to retrieve the index of the item you are looking for that is associated with the index you choose
        private static int GetLeftChildIndex(int parentIndex) { return (2 * parentIndex + 1); }
        private static int GetRightChildIndex(int parentIndex) { return (2 * parentIndex + 2); }
        private static int GetParentIndex(int index) { return (index - 1) / 2; }

        // Methods to retrieve whether or not the items associated to the index exist
        private static bool HasLeftChild(int index) { return GetLeftChildIndex(index) < size - 1; }
        private static bool HasRightChild(int index) { return GetRightChildIndex(index) < size - 1; }
        private static bool HasParent(int index) { if (index == 0) return false; return GetParentIndex(index) >= 0; }

        // Methods to retrieve the actual value of the item using the parent index
        private static int LeftChild(int index) { return items[GetLeftChildIndex(index)]; }
        private static int RightChild(int index) { return items[GetRightChildIndex(index)]; }
        private static int Parent(int index) { return items[GetParentIndex(index)]; }


        /// <summary>
        /// Makes sure that hte array has enough space for more items by doubling the size of the array
        /// </summary>
        private static void EnsureCapacity()
        {
            if (size + 1 == capacity)
            {
                int[] newArray = new int[capacity * 2];
                for (int i = 0; i < capacity; i++)
                    newArray[i] = items[i];
                items = newArray;
                capacity *= 2;
            }
        }
        
        /// <summary>
        /// Swaps the last item in the heap with the first item which is moved down to fit the logic then returns the item at index 0
        /// </summary>
        /// <returns>The item at index 0</returns>
        public int Poll()
        {
            Console.WriteLine("--------------------------------------------------POLL");
            if (size == 0) throw new Exception();
            int temp = items[0];
            items[0] = items[size - 1];
            size--;

            Traverse();       
            HeapifyDown();
            Traverse();
            return temp;
        }

        /// <summary>
        /// Adds the item at the end of the heap and bubbles the number upwards until it is in a satisfactory position
        /// </summary>
        /// <param name="value">The item to be inserted</param>
        public void Add(int value)
        {
            EnsureCapacity();
            items[size] = value;
            size++;

            HeapifyUp();
            Traverse();
        }

        /// <summary>
        /// Bubbles a number downwards until it reaches a satisfactory position
        /// </summary>
        private static void HeapifyDown()
        {
            int index = 0;
            int smallerChildIndex = 0;

            // Get the smallest value between the left and right child and swaps the parent with that item if the parent is less than the child item and gets the new index if swapped
            while ((HasLeftChild(index)))
            {               
                smallerChildIndex = GetLeftChildIndex(index);

                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                    smallerChildIndex = GetRightChildIndex(index);

                if (items[index] < items[smallerChildIndex])
                {
                    break;
                }      
                else
                {
                    Swap(index, smallerChildIndex);
                }

                index = smallerChildIndex;
            }

            Console.WriteLine($"--------------------------------------------------index swapped: {smallerChildIndex}");
        }

        /// <summary>
        /// Bubbles a number downards until it reaches a satisfactory position
        /// </summary>
        private static void HeapifyUp()
        {
            int index = size - 1;

            // Swaps he number based on whether or not the number is smaler than the number abouve it
            while (HasParent(index) && items[GetParentIndex(index)] > items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }



        // ========================================================================================================================================


        /// <summary>
        /// Displays the item at the top of the heap
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return items[0];
        }

        /// <summary>
        /// Swaps the numbers at the specified indeces
        /// </summary>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        private static void Swap(int index1, int index2)
        {
            int temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }

        /// <summary>
        /// Traverse the heap
        /// </summary>
        public void Traverse()
        {
            Console.WriteLine("Traverse");
            int oldHeight = 0;
            int originalHeight = (int)Math.Ceiling(Math.Log(size + 2, 2));
            for (int i = 0; i < size; i++)
            {
                int height = (int)Math.Ceiling(Math.Log(i + 2, 2));

                if (height > oldHeight)
                {
                    //Console.WriteLine("\n" + $"ht: {height - 1}");
                    Console.WriteLine();
                    oldHeight = height;
                    for (int x = 0; x < originalHeight - height; x++)
                        Console.Write("\t");
                }
                Console.Write($"[{i}]-{items[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
        }


        /// <summary>
        /// Traverse the heap but show it as an upside down pyramid
        /// </summary>
        public void TraverseBottomUp()
        {
            Console.WriteLine("Traverse Bottom Up");

            int oldHeight = (int)Math.Ceiling(Math.Log(size + 2, 2));
            int originalHeight = oldHeight;

            Console.WriteLine("\n" + $"height: {oldHeight}");
            for (int i = size; i >= 0; i--)
            {
                int height = (int)Math.Ceiling(Math.Log(i + 2, 2));

                if (height < oldHeight)
                {
                    Console.WriteLine("\n\n" + $"ht: {height - 1}");
                    oldHeight = height;
                    for (int x = 0; x < originalHeight - height; x++)
                        Console.Write("\t");
                }
                Console.Write($"[{i}]-{items[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
