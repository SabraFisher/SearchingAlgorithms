using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    static class SearchAlgorithms
    {
        //public static int BinarySearch(int[] array, int target)
        //{
        //    int left = 0;
        //    int right = array.Length - 1;
        //    while (left <= right)
        //    {
        //        int mid = left + (right - left) / 2;
        //        if (array[mid] == target)
        //            return mid;
        //        if (array[mid] < target)
        //            left = mid + 1;
        //        else
        //            right = mid - 1;
        //    }
        //    return -1; // Target not found
        //}

        public static int BinarySearch<T>(T[] arr, int low, int high, T searchTerm) where T : IComparable<T> 
        {
            int mid = (low + high) / 2;
            if (arr[mid].Equals(searchTerm))
            {
                return mid;
            }

            if (arr[mid].CompareTo(searchTerm) > 0 && low < high)
            {
                return BinarySearch(arr, low, mid - 1, searchTerm);
            }

            else if (low >= high)
            {
                return -1;
            }
            else if (arr[mid].CompareTo(searchTerm) < 0)
            {
                return BinarySearch(arr, mid + 1, high, searchTerm);
            }
            else
            {
                return BinarySearch(arr, low, mid - 1, searchTerm);
            }
        }



         public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                    return i;
            }
            return -1; // Target not found
        }


    }
}
