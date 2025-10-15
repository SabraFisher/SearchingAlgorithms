using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    static class Algorithms
        {
        //Searching algorithms
        //refactored linear search to be generic
        public static int LinearSearch<T>(T[] arr, T searchTerm) where T : IComparable<T>  //returns first instance of searchTerm
        {
            for (int i = 0; i < arr.Length; i++) //search from the beginning of the array to the end
            {
                if (arr[i].Equals(searchTerm))
                {  //is this the search term?
                     return i ;
                }
            }

            return -1; // if target not found
        }

        //data must be sorted prior to searching
        //function: Takes a sorted array, splits it in two and searches both halves recursively for a matching search term
        public static int BinarySearch<T>(T[] arr, int low, int high, T searchTerm) where T : IComparable<T>
        {   // only works on sorted arrays
            //base case - if low is greater than high, the searchTerm is not in the array
            int mid = low + ((high-low) / 2);

            if (arr[mid].Equals(searchTerm))
            {
                return mid;
            }

            //recursive case
            if (arr[mid].CompareTo(searchTerm) < 0) // mid is less than searchTerm
            {
                BinarySearch(arr, mid + 1, high, searchTerm);
            }
            
            else if (arr[mid].CompareTo(searchTerm) > 0) // mid is greater than searchTerm
            {
                BinarySearch(arr, low, mid - 1, searchTerm);
            }

            return -1; // if target not found
        }

        

       


      


    }
}
