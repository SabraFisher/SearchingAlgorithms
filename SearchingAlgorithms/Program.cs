using System.Diagnostics;
using System;

namespace SearchingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            // usage 100 thousand values
            stopwatch.Start();
            int[] largeArr = GenerateArray(10, 1, 10);
            stopwatch.Stop();
            DisplayRuntime(stopwatch);

            //print the array
            stopwatch.Start();
            for (int i = 0; i < largeArr.Length; i++)
            {
                Console.Write(largeArr[i] + " ");
            }
            stopwatch.Stop();
            DisplayRuntime(stopwatch);

            //search for a number in the array
            stopwatch.Start();
            Console.WriteLine("\n3 ws found at index:  " + Algorithms.LinearSearch(largeArr, 3));
            stopwatch.Stop();
            DisplayRuntime(stopwatch);

            // Write your function to test each algorithm here


            // Write individual functions for each algorithm here (Bubble, Insertion, Merge, and Quick sort)


            // function
            static int[] GenerateArray(int numElements, int min, int max)
            {
                Random rand = new Random();
                int[] arr = new int[numElements];

                for (int i = 0; i < numElements; i++)
                {
                    arr[i] = rand.Next(min, max);// Generates a random integer within the specified range
                }

                return arr;
            }

            static void DisplayRuntime(Stopwatch stopwatch)
            {
                TimeSpan ts = stopwatch.Elapsed;

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                Console.WriteLine("Time Taken: " + elapsedTime);
            }


            static List<int> GenerateBigList(int size)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    list.Add(i);
                }
                return list;
            }
            List<int> nums = GenerateBigList(1000000);
            nums.Add(-1);

            //LINKED LIST EXAMPLE
            //List<int> nums = new List<int>{ 2, 4, 1, 5, 6, 2, 9, 10, 222000 };

            Console.WriteLine("Nums contains a lenght of :  " + nums.Count);
            Console.WriteLine("First element of num is : " + nums[0]);
            Console.WriteLine("Last element of num is : " + nums[nums.Count - 1]);)
            //Implement a function that uses the System.Diagnostics.Stopwatch class to measure the execution time of
            //  the following sorting algorithms:
            //                              Quick Sort
            //                              Merge Sort
            //                              Bubble Sort
            //                              Insertion Sort

            //Measure the time taken to sort the array using each algorithm.Display the results in the format:

            //Algorithm: [Name] Time Taken: [milliseconds]
            //Based on the results, add a comment explaining why certain algorithms are more efficient than others for large datasets.
        }
    }
}
