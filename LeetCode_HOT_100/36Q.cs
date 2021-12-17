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
            if (node == p)
            {
                node = root;
                return;
            }
            if (root == p)
                node = root;

            Process(root.right, p);
        }

        //1. 首先要确定中序遍历的后继:

        //如果该节点有右子节点, 那么后继是其右子节点的子树中最左端的节点
        //如果该节点没有右子节点, 那么后继是离它最近的祖先, 该节点在这个祖先的左子树内.
        //2. 使用递归实现:

        //- 如果根节点小于或等于要查找的节点p, 直接进入右子树递归
        //- 如果根节点大于要查找的节点, 则暂存左子树递归查找的结果,
        //    - 如果是 null, 说明在该根节点的左子树中没找到比p大的节点，也就说明该根节点就是要找的p的后继，则直接返回当前根节点;
        //    - 如果不是 null,说明找到了答案，返回左子树递归查找的结果
        public TreeNode InorderSuccessor1(TreeNode root, TreeNode p)
        {
            if (root == null || p == null)
                return null;
            if (root.val < p.val)
            {
                TreeNode right = InorderSuccessor1(root.right, p);
                return right;
            }
            else
            {
                TreeNode left = InorderSuccessor1(root.left, p);
                return left != null ? left : root;
            }
        }
    }
}
