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
            Console.WriteLine("Hello World!");
        }
    }
}
