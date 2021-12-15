using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 04.05. 合法二叉搜索树
    //实现一个函数，检查一棵二叉树是否为二叉搜索树。

    //示例 1:
    //输入:
    //    2
    //   / \
    //  1   3
    //输出: true
    //示例 2:
    //输入:
    //    5
    //   / \
    //  1   4
    //     / \
    //    3   6
    //输出: false
    //解释: 输入为: [5,1,4,null,null,3,6]。
    //     根节点的值为 5 ，但是其右子节点值为 4 。
    public class Solution35
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public bool IsValidBST(TreeNode root)
        {

        }

        private Info Process(TreeNode head)
        {
            if (head == null)
                return null;

            Info leftInfo = Process(head.left);
            Info rightInfo = Process(head.right);

            int min = head.val;
            int max = head.val;
            bool isBst = false;

            if (leftInfo != null)
            {
                min = Math.Min(min, leftInfo.MinValue);
                max = Math.Min(max, leftInfo.MaxValue);
            }
            if (rightInfo != null)
            {
                min = Math.Min(min, rightInfo.MinValue);
                max = Math.Max(max, rightInfo.MaxValue);
            }

            if ((leftInfo == null ? true : leftInfo.IsBst) && (rightInfo == null ? true : rightInfo.IsBst))
            {
                isBst = true;
            }
            return new Info(isBst, max, min);
        }

        private class Info
        {
            //是否为搜索树
            public bool IsBst { get; set; }

            //最大值
            public int MinValue { get; set; }

            //最小值
            public int MaxValue { get; set; }

            public Info(bool b, int max, int min)
            {
                IsBst = b;
                MinValue = min;
                MaxValue = max;
            }

        }
    }
}
