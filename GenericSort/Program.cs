using System.Collections;
using System.Collections.Generic;

namespace GenericSortNS
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
            string[] words = { "banana", "apple", "cherry", "date" };
            double[] doubles = { 19.5, 19.2, 19.1, 19.0, 19.7, 19.9 };

            InsertionSort(numbers);
            InsertionSort(words);
            InsertionSort(doubles);

            PrintArray(numbers);
            PrintArray(words);
            PrintArray(doubles);
        }

        /// <summary>
        /// This method prints all the elements of an array.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr">An array of elements of type T.</param>

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T i in arr)
                Console.Write(" " + i);
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// This method sorts an array of type T using the Insertion Sort algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array">An array of elements of type T.</param>

        public static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T item = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(item) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = item;
            }
        }
    }
}
