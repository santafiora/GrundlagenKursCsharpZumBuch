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

            // Sort the array using bubble sort
            BubbleSort(arr);
            Console.ReadKey();
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int swapCounter = 0;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap the elements
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapCounter++;
                    }
                }

                // Print the sorted array and the number of swaps made after each iteration
                Console.WriteLine("Sorted array after iteration " + (i + 1) + ":");
                PrintArray(arr);
                Console.WriteLine("Number of swaps: " + swapCounter);
            }
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