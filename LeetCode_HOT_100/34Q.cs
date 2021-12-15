using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 04.04. 检查平衡性
    //实现一个函数，检查二叉树是否平衡。在这个问题中，平衡树的定义如下：任意一个节点，其两棵子树的高度差不超过 1。


    //示例 1:
    //给定二叉树[3, 9, 20, null, null, 15, 7]
    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //返回 true 。
    //示例 2:
    //给定二叉树[1, 2, 2, 3, 3, null, null, 4, 4]
    //      1
    //     / \
    //    2   2
    //   / \
    //  3   3
    // / \
    //4   4
    //返回 false 。
    //[1,2,2,3,3,null,null,4,4]
    public class Solution34
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool IsBalanced(TreeNode root)
        {
            return Process(root).IsBalanced;
        }

        private Info Process(TreeNode head)
        {
            if (head == null)
                return new Info(true, 0);

            Info dataLeft = Process(head.left);
            Info dataRight = Process(head.right);

            int height = Math.Max(dataLeft.Height, dataRight.Height)+1;
            bool isBalance = true;
            if(!dataLeft.IsBalanced||!dataRight.IsBalanced||(Math.Abs(dataLeft.Height-dataRight.Height)>1))
            {
                isBalance = false;
            }

            return new Info(isBalance, height);
        }

        private class Info
        {
            public bool IsBalanced { get; set; }

            public int Height { get; set; }

            public Info(bool b, int h)
            {
                IsBalanced = b;
                Height = h;
            }
        }
    }
}
