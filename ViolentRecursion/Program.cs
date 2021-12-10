using System;

namespace ViolentRecursion
{
    public class Program
    {
        static void Main(string[] args)
        {
            RobotWalk.Test();
            Console.WriteLine("Hello World!");
        }

        public static int[] GenerateRandomArray(int len, int max)
        {
            Random rd = new Random();
            int[] arr = new int[rd.Next(1) * len + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(max) + 1;
            }
            return arr;
        }

        public static void TestCase()
        {
            int len = 10;
            int max = 10;
            int testTime = 10000;
            for (int i = 0; i < testTime; i++)
            {
                int[] arr = GenerateRandomArray(len, max);
                //todo test
            }
        }
    }
}
