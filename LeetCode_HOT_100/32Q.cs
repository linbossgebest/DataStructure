using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 04.02. 最小高度树
    //给定一个有序整数数组，元素各不相同且按升序排列，编写一个算法，创建一棵高度最小的二叉搜索树。

    //示例:
    //给定有序数组: [-10,-3,0,5,9],

    //一个可能的答案是：[0,-3,9,-10,null,5]，它可以表示下面这个高度平衡二叉搜索树：

    //          0 
    //         / \ 
    //       -3   9 
    //       /   / 
    //     -10  5 
    public class Solution32
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            return GenerateMinBST(nums, 0, nums.Length);
        }

        private TreeNode GenerateMinBST(int[] nums, int left, int right)
        {
            if (left == right)
                return null;

            int mid = (left + right) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = GenerateMinBST(nums, left, mid);
            node.right = GenerateMinBST(nums, mid + 1, right);

            return node;
        }
    }
}
