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

            //Solution42 s42 = new Solution42();
            //ListNode node1 = new ListNode(1);
            //ListNode node2 = new ListNode(1);
            //ListNode node3 = new ListNode(2);
            //node1.next = node2;
            //node2.next = node3;
            //s42.DeleteDuplicates(node1);

            //Solution45 s45 = new Solution45();
            //ListNode node1 = new ListNode(1);
            //ListNode node2 = new ListNode(2);
            //node1.next = node2;
            //s45.IsPalindrome(node1);

            //Solution49 s49 = new Solution49();
            //string s = "3[a]2[bc]";
            ////string s = "3[a2[c]]";
            ////string s = "abc3[cd]xyz";
            ////string s = "100[leetcode]";
            //string res = s49.DecodeString(s);
            //Console.WriteLine(res);

            //Solution55 s55 = new Solution55();
            //TreeNode root = new TreeNode(4);
            //TreeNode left = new TreeNode(2);
            //TreeNode right = new TreeNode(7);
            //root.left = left;
            //root.right = right;
            //var res= s55.InvertTree(root);


            //Solution58 s58 = new Solution58();
            //s58.IsValid("{[]}");

            //int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7};
            //Solution67 s67 = new Solution67();
            //s67.MaxArea(height);

            //int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            //Solution68 s68 = new Solution68();
            //s68.ThreeSum(nums);

            //string s = "23";
            //Solution69 s69 = new Solution69();
            //s69.LetterCombinations(s);

            //Solution70 s70 = new Solution70();
            //s70.GenerateParenthesis1(2);

            //Solution72 s72 = new Solution72();
            //int[] nums = new int[] { 3,1 };
            //s72.Search(nums, 1);

            //int[] nums = new int[] {1,2,3,4,5,5,6,6,7,8,8,8,9,10 };
            //int[] nums = new int[] { 1 };
            //Solution73 s73 = new Solution73();
            //s73.SearchRange(nums, 1);

            //int[] nums = new int[] { 2, 3, 6, 7 };
            //Solution74 s74 = new Solution74();
            //s74.CombinationSum(nums, 7);

            //int[] nums = { 1, 2, 3 };
            //Solution75 s75 = new Solution75();
            //s75.Permute(nums);

            //string[] strs = { "eat","tea","tan","ate","nat","bat" };
            //Solution76 s76 = new Solution76();
            //s76.GroupAnagrams(strs);

            //int[][] res = new int[][]
            //{
            //    new int[]{1,9},
            //     new int[]{2,5},
            //      new int[]{19,20},
            //       new int[]{10,11},
            //        new int[]{12,20},
            //         new int[]{0,3},
            //          new int[]{0,1},
            //           new int[]{0,2},
            //};
            //Solution78 s78 = new Solution78();
            //s78.Merge(res);

            //int[][] res = new int[][] {
            //new int[]{ 1,3,1},
            //new int[] { 1,5,1},
            //new int[] { 4,2,1}
            //};
            //Solution80 s80 = new Solution80();
            //s80.MinPathSum(res);

            //int[] nums = new int[]{ 2, 0, 2, 1, 1, 0 };
            //Solution81 s81 = new Solution81();
            //s81.SortColors1(nums);

            //char[][] res = new char[][]
            //{
            //    new char[]{'A', 'B', 'C', 'E'},
            //    new char[]{'S', 'F', 'C', 'S'},
            //    new char[]{'A', 'D', 'E', 'E' }
            //};
            //Solution83 s83 = new Solution83();
            //s83.Exist(res, "ABCB");

            //int[] preorder = new int[] { 3, 9, 20, 15, 7 };
            //int[] inorder = new int[] { 9, 3, 15, 20, 7 };
            //Solution85 s85 = new Solution85();
            //s85.BuildTree(preorder,inorder);

            var s = "leetcode";
            var wordDict = new string[] { "leet", "code" };
            Solution88 s88 = new Solution88();
            s88.WordBreak(s,wordDict);

        }


    }
}
