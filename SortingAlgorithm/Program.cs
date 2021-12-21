using System;

namespace SortingAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 5, 8, 3, 2, 4, 9 };
            //QuickSort qs = new QuickSort();
            //int[] nums = new int[] { 1, 5, 8, 3, 2, 4, 9 };
            //qs.SortArray(nums);

            //InsertionSort iS= new InsertionSort();
            //iS.SortArray(nums);

            ShellSort ss = new ShellSort();
            ss.SortArray(nums);
        }
    }
}
