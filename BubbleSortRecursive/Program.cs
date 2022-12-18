using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Initialize an unsorted array
            int[] arr = { 5, 1, 4, 2, 8 };

            // Print the unsorted array
            Console.WriteLine("Original array:");
            PrintArray(arr);

            // Sort the array using recursive bubble sort
            BubbleSort(arr, arr.Length);

            // Print the sorted array
            Console.WriteLine("Sorted array:");
            PrintArray(arr);

            Console.ReadKey();
        }

        public static void BubbleSort(int[] arr, int n)
        {
            // Base case: If the array is sorted, return
            bool isSorted = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            if (isSorted) return;

            // Recursive case: Iterate through the array and swap adjacent elements if necessary
            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    // Swap the elements
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            // Recursively sort the array
            BubbleSort(arr, n - 1);
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
