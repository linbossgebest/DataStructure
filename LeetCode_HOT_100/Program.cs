using System;

namespace LeetCode_HOT_100
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "cbbd";
            //string str = "babad";
            //Solution5 s5 = new Solution5();
            //var temp1=s5.LongestPalindrome(str);
            //Console.WriteLine(temp1);



            //var matrix = new int[][] {
            //new int[]{ 1, 2, 3 },
            //new int[]{ 4,5,6},
            //new int[] { 7,8,9}
            //};
            //Solution14 s14 = new Solution14();
            //s14.Rotate(matrix);

            //Solution31 s31 = new Solution31();
            //s31.Test();

            //Solution38 s38 = new Solution38();
            //s38.Merge2(new int[] { 0},0,new int []{ 1},1);


            //Solution40 s40 = new Solution40();
            //int[] nums = new int[]{ 4, 3, 2, 7, 8, 2, 3, 1 };
            //s40.FindDisappearedNumbers(nums);

            Solution42 s42 = new Solution42();
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(1);
            ListNode node3 = new ListNode(2);
            node1.next = node2;
            node2.next = node3;
            s42.DeleteDuplicates(node1);

        }


    }
}
