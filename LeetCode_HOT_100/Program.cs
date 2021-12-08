using System;

namespace LeetCode_HOT_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "cbbd";
            string str = "babad";
            Solution5 s5 = new Solution5();
            var temp1=s5.LongestPalindrome(str);
            Console.WriteLine(temp1);



            var matrix = new int[][] {
            new int[]{ 1, 2, 3 },
            new int[]{ 4,5,6},
            new int[] { 7,8,9}
            };
            Solution14 s14 = new Solution14();
            s14.Rotate(matrix);


            Console.WriteLine("Hello World!");
        }
    }
}
