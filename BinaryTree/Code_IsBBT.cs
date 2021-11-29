using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    //Q:给定一个二叉树的头节点head,返回这颗树是否为平衡二叉树
    public static class Code_IsBBT<T>
    {
        //平衡二叉树条件分解：
        //1.左树平衡
        //2.右树平衡
        //3.|左树高度-右树高度|<2

        public static bool IsBBT(Node<T> head)
        {
            if (head == null)
                return true;

            return Process(head).IsBalanced;
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

        private static Info Process(Node<T> head)
        {
            if (head == null)
                return new Info(true, 0);

            Info dataLeft = Process(head.Left);
            Info dataRight = Process(head.Right);

            int height = Math.Max(dataLeft.Height, dataRight.Height) + 1;
            bool IsBalance = true;
            if(!dataLeft.IsBalanced||!dataRight.IsBalanced||Math.Abs(dataLeft.Height-dataRight.Height)>2)
            {
                IsBalance = false;
            }


            return new Info(IsBalance, height);
        }
    }
}
