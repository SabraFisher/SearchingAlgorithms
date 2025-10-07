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
            int[] largeArr = GenerateArray(1000000, 1);
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
                    arr[i] = rand.Next();// Generates a random integer within the specified range
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
