using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    144. 二叉树的前序遍历
    //给你二叉树的根节点 root ，返回它节点值的 前序 遍历。



    //示例 1：


    //输入：root = [1,null,2,3]
    //    输出：[1,2,3]
    //    示例 2：

    //输入：root = []
    //    输出：[]
    //    示例 3：

    //输入：root = [1]
    //    输出：[1]
    //    示例 4：


    //输入：root = [1,2]
    //    输出：[1,2]
    //    示例 5：


    //输入：root = [1,null,2]
    //    输出：[1,2]


    //    提示：

    //树中节点数目在范围[0, 100] 内
    //-100 <= Node.val <= 100


    //进阶：递归算法很简单，你可以通过迭代算法完成吗？
    public class Solution51
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Process(root, res);
            return res;
        }

        private void Process(TreeNode root, List<int> res)
        {
            if (root == null)
                return;

            res.Add(root.val);
            Process(root.left, res);
            Process(root.right, res);
        }

        public IList<int> PreorderTraversal1(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                while (root != null)
                {
                    res.Add(root.val);
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                root = root.right;
            }
            return res;
        }
    }
}
