using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    //Q:给定一个二叉树的头节点head,返回这颗树是否为满二叉树
    public static class Code_IsFBT<T>
    {
        //满二叉树满足条件：节点数=2^树的高度-1

        /// <summary>
        /// 判断是否为 满二叉树
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool IsFBT(Node<T> head)
        {
            if (head == null)
                return true;

            Info data = Process(head);
            return data.nodes == Math.Pow(2, data.height) - 1;
                //(1 << data.height - 1);
        }

        private class Info
        {
            public int height { get; set; }
            public int nodes { get; set; }

            public Info(int h, int n)
            {
                height = h;
                nodes = n;
            }
        }

        private static Info Process(Node<T> head)
        {
            if (head == null)
                return new Info(0, 0);

            Info leftData = Process(head.Left);
            Info rightData = Process(head.Right);

            int height=Math.Max(leftData.height,rightData.height)+1;
            int nodes=leftData.nodes+rightData.nodes+1;

            return new Info(height,nodes);
        }
    }
}
