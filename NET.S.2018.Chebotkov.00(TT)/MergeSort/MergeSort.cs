namespace MergeSortLib
{
    public static class MergeSort
    {
        public static void Sort(int[] arr, int top, int end)
        {
            if (top < end && top >= 0)
            {
                Sort(arr, top, (top + end) / 2);
                Sort(arr, (top + end) / 2 + 1, end);
                Merge(arr, top, end);
            }

            else if (top != end)
            {
                throw new System.IndexOutOfRangeException();
            }
        }

        static void Merge(int[] arr, int top, int end)
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
                arr[i] = result[i];
        }
    }
}
