using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    105. 从前序与中序遍历序列构造二叉树
    //给定一棵树的前序遍历 preorder 与中序遍历  inorder。请构造二叉树并返回其根节点。



    //示例 1:


    //Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
    //    Output: [3,9,20,null,null,15,7]
    //    示例 2:

    //Input: preorder = [-1], inorder = [-1]
    //    Output: [-1]


    //    提示:
    //1 <= preorder.length <= 3000
    //inorder.length == preorder.length
    //-3000 <= preorder[i], inorder[i] <= 3000
    //preorder 和 inorder 均无重复元素
    //inorder 均出现在 preorder
    //preorder 保证为二叉树的前序遍历序列
    //inorder 保证为二叉树的中序遍历序列

    //前序遍历:[ 根节点, [左子树的前序遍历结果], [右子树的前序遍历结果] ]
    //中序遍历:[ [左子树的中序遍历结果], 根节点, [右子树的中序遍历结果] ]
    //preorder = [3,9,20,15,7]
    //inorder = [9,3,15,20,7]
    //首先根据 preorder 找到根节点是 3

    //然后根据根节点将 inorder 分成左子树和右子树
    //左子树
    //inorder[9]

    //右子树
    //inorder[15, 20, 7]

    //把相应的前序遍历的数组也加进来
    //左子树
    //preorder[9]
    //inorder[9]

    //右子树
    //preorder[20 15 7]
    //inorder[15, 20, 7]

    //现在我们只需要构造左子树和右子树即可，成功把大问题化成了小问题
    //然后重复上边的步骤继续划分，直到 preorder 和 inorder 都为空，返回 null 即可

    public class Solution85
    {
        Dictionary<int, int> dic;
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            dic = new Dictionary<int, int>();
            int n = preorder.Length;
            for (int i = 0; i < n; i++)
                dic.Add(inorder[i], i);

            return Process(preorder, inorder, 0, n - 1, 0, n - 1);
        }

        public TreeNode Process(int[] preorder, int[] inorder, int preorder_left, int preorder_right, int inorder_left, int inorder_right)
        {
            if (preorder_left > preorder_right)
                return null;

            int preorder_root = preorder_left;
            int inorder_root = dic[preorder[preorder_root]];

            TreeNode root = new TreeNode(preorder[preorder_root]);
            //得到左子树中的节点数目
            int left_subtree_size = inorder_root - inorder_left;
            root.left = Process(preorder, inorder, preorder_left + 1, preorder_left + left_subtree_size, inorder_left, inorder_root - 1);
            root.right = Process(preorder, inorder, preorder_left + left_subtree_size + 1, preorder_right, inorder_root + 1, inorder_right);

            return root;
        }
    }
}
