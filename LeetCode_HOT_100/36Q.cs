using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 04.06. 后继者
    //设计一个算法，找出二叉搜索树中指定节点的“下一个”节点（也即中序后继）。

    //如果指定节点没有对应的“下一个”节点，则返回null。

    //示例 1:

    //输入: root = [2,1,3], p = 1

    //  2
    // / \
    //1   3

    //输出: 2
    //示例 2:

    //输入: root = [5,3,6,2,4,null,null,1], p = 6

    //      5
    //     / \
    //    3   6
    //   / \
    //  2   4
    // /   
    //1

    //输出: null
    public class Solution36
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        TreeNode node;
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            Process(root, p);
            return node == p ? null : node;
        }

        private void Process(TreeNode root, TreeNode p)
        {
            if (root == null)
                return;

            Process(root.left, p);
            if (node == p) {
                node = root;
                return;
            }
            if (root == p)
                node = root;

            Process(root.right, p);
        }
    }
}
