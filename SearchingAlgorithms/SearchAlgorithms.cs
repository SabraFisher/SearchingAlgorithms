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

        public static int RecursiveBinarySearch<T>(T[] arr, int low, int high, T searchTerm) where T : IComparable<T> 
        {
            int mid = (low + high) / 2;
            if (arr[mid].Equals(searchTerm))
            {
                return mid;
            }

            if (arr[mid].CompareTo(searchTerm) > 0 && low < high)
            {
                return RecursiveBinarySearch(arr, low, mid - 1, searchTerm);
            }

            else if (low >= high)
            {
                return -1;
            }
            else if (arr[mid].CompareTo(searchTerm) < 0)
            {
                return RecursiveBinarySearch(arr, mid + 1, high, searchTerm);
            }
            else
            {
                return RecursiveBinarySearch(arr, low, mid - 1, searchTerm);
            }
        }

        static int IterativeBinarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                //check if x id pressent at mid
                if (arr[mid] == x)
                    return mid;
                //if x is greater, ignore left half
                if (arr[mid] < x)
                    low = mid + 1;
                //if x is smaller, ignore right half
                else
                    high = mid - 1;
            }
            return -1;
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
