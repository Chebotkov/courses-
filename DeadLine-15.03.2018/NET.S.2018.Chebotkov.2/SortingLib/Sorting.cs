﻿namespace SotringLib
{
    /// <summary>
    /// This class implements "Quick Sort" and "Merge sort" algorithms for array of integers
    /// </summary>
    public class Sorting
    {
        /// <summary>
        /// This method sorts array by "Merge Sort"
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="top">First index of array</param>
        /// <param name="end">Last index of array</param>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static void MergeSort(int[] arr, int top, int end)
        {
            if (top < end && top >= 0)
            {
                MergeSort(arr, top, (top + end) / 2);
                MergeSort(arr, ((top + end) / 2) + 1, end);
                Merge(arr, top, end);
            }
            else if (top != end)
            {
                throw new System.IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// This method sorts array by "Quick Sort"
        /// </summary>
        /// <param name="a">Array</param>
        /// <param name="left">First index of array</param>
        /// <param name="right">Last index of array</param>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        public static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int i = left, j = right;
                int mid = a[(left + right) / 2];

                do
                {
                    while (a[i] < mid)
                    {
                        i++;
                    }

                    while (a[j] > mid)
                    {
                        j--;
                    }

                    if (i <= j)
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                        i++;
                        j--;
                    }
                }
                while (i < j);

                if (left < j)
                {
                    QuickSort(a, left, j);
                }

                if (i < right)
                {
                    QuickSort(a, i, right);
                }
            }
            else
            {
                throw new System.IndexOutOfRangeException();
            }
        }

        /// <summary>
        /// This method sorts array by "Merge Sort"
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="top">First index of array</param>
        /// <param name="end">Last index of array</param>
        /// <exception cref="System.IndexOutOfRangeException"></exception>
        private static void Merge(int[] arr, int top, int end)
        {
            int[] result = new int[arr.Length];
            int mid = (top + end) / 2;
            int firstLeft = top;
            int firstRight = mid + 1;

            for (int i = top; i <= end; i++)
            {
                if (firstLeft > mid)
                {
                    result[i] = arr[firstRight++];
                }
                else if (firstRight > end)
                {
                    result[i] = arr[firstLeft++];
                }
                else if (arr[firstLeft] < arr[firstRight])
                {
                    result[i] = arr[firstLeft++];
                }
                else
                {
                    result[i] = arr[firstRight++];
                }
            }

            for (int i = top; i <= end; i++)
            {
                arr[i] = result[i];
            }
        }
    }
}
