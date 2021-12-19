using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    94. 二叉树的中序遍历
    //给定一个二叉树的根节点 root ，返回它的 中序 遍历。



    //示例 1：


    //输入：root = [1,null,2,3]
    //    输出：[1,3,2]
    //    示例 2：

    //输入：root = []
    //    输出：[]
    //    示例 3：

    //输入：root = [1]
    //    输出：[1]
    //    示例 4：


    //输入：root = [1,2]
    //    输出：[2,1]
    //    示例 5：


    //输入：root = [1,null,2]
    //    输出：[1,2]


    //    提示：

    //树中节点数目在范围[0, 100] 内
    //-100 <= Node.val <= 100


    //进阶: 递归算法很简单，你可以通过迭代算法完成吗？
    public class Solution50
    {
        public IList<int> InorderTraversal(TreeNode root)
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
            res.Add(root.val);
            Process(root.right, res);
        }

        public IList<int> InorderTraversal1(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (root != null || stack.Count > 0)
            {
                while (root != null) 
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                res.Add(root.val);
                root = root.right;
            }
            return res;
        }
    }
}
