using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //     04.03. 特定深度节点链表
    //给定一棵二叉树，设计一个算法，创建含有某一深度上所有节点的链表（比如，若一棵树的深度为 D，则会创建出 D 个链表）。返回一个包含所有深度的链表的数组。



    //示例：

    //输入：[1,2,3,4,5,null,7,8]

    //        1
    //       /  \ 
    //      2    3
    //     / \    \ 
    //    4   5    7
    //   /
    //  8

    //输出：[[1],[2,3],[4,5,7],[8]]
    public class Solution33
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode[] ListOfDepth(TreeNode tree)
        {
            if (tree == null)
                return null;

            List<ListNode> listNodes = new List<ListNode>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(tree);
            while (queue.Count > 0)
            {
                var t = queue.Peek();

                queue.Enqueue(t.left);
                queue.Enqueue(t.right);
            }
        }
    }
}
