using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    145. 二叉树的后序遍历
    //给定一个二叉树，返回它的 后序 遍历。

    //示例:

    //输入: [1,null,2,3]  
    //   1
    //    \
    //     2
    //    /
    //   3 

    //输出: [3,2,1]
    //    进阶: 递归算法很简单，你可以通过迭代算法完成吗？
    public class Solution52
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Process(root, res);
            return res;
        }

        private void Process(TreeNode root, List<int> res)
        {
            if (root == null)
                return;

            Process(root.left, res);
            Process(root.right, res);
            res.Add(root.val);
        }

        public IList<int> PostorderTraversal1(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode pre = null;
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (root.right == null || root.right == pre)
                {
                    res.Add(root.val);
                    pre = root;
                    root = null;
                }
                else
                {
                    stack.Push(root);
                    root = root.right;
                }
            }
            return res;
        }
    }
}
