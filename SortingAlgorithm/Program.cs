using System;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort qs = new QuickSort();
            int[] nums = new int[] { 1, 5, 8, 3, 2, 4, 9 };
            qs.SortArray(nums);
            Console.WriteLine(nums);
        }
    }
}
