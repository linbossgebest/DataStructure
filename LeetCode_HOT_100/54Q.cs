using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    104. 二叉树的最大深度
    //给定一个二叉树，找出其最大深度。

    //二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

    //说明: 叶子节点是指没有子节点的节点。

    //示例：
    //给定二叉树[3, 9, 20, null, null, 15, 7]，

    //    3
    //   / \
    //  9  20
    //    /  \
    //   15   7
    //返回它的最大深度 3 。
    public class Solution54
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }

        public int MaxDepth1(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int depth = 0;
            while (queue.Count > 0)
            {
                int size = queue.Count;
                while (size > 0)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                        queue.Enqueue(node.left);

                    if (node.right != null)
                        queue.Enqueue(node.right);

                    size--;
                }
                depth++;
            }
            return depth;
        }
    }
}
