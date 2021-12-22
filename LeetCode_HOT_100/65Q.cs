using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    543. 二叉树的直径
    //给定一棵二叉树，你需要计算它的直径长度。一棵二叉树的直径长度是任意两个结点路径长度中的最大值。这条路径可能穿过也可能不穿过根结点。

    //示例 :
    //给定二叉树

    //          1
    //         / \
    //        2   3
    //       / \     
    //      4   5    
    //返回 3, 它的长度是路径[4, 2, 1, 3] 或者[5, 2, 1, 3]。

    //注意：两结点之间的路径长度是以它们之间边的数目表示。
    public class Solution65
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

            return Process(root).MaxDistance - 1;
        }

        private class Info
        {
            public int MaxDistance { get; set; }

            public int Height { get; set; }

            public Info(int maxDistance, int height)
            {
                MaxDistance = maxDistance;
                Height = height;
            }
        }

        private static Info Process(TreeNode head)
        {
            if (head == null)
                return new Info(0, 0);

            Info dataLeft = Process(head.left);
            Info dataRight = Process(head.right);

            int height = Math.Max(dataLeft.Height, dataRight.Height) + 1;
            int maxDistance = Math.Max(Math.Max(dataLeft.MaxDistance, dataRight.MaxDistance), dataLeft.Height + dataRight.Height + 1);

            return new Info(maxDistance, height);
        }
    }
}
