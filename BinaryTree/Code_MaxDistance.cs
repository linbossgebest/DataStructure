using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    //Q:给定一棵二叉树头节点head,任何两个节点之间都存在距离，返回整个二叉树的最大距离
    public static class Code_MaxDistance<T>
    {
        //条件：
        //1.与头节点X相关
        //maxDistance=左树.Height+右树.Height+1
        //2.与头节点X无关
        //maxDistance=Math.Max(左树.maxDistance,右树.maxDistance)

        public static int MaxDistance(Node<T> head)
        {
            if (head == null)
                return 0;

            return Process(head).MaxDistance;
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

        private static Info Process(Node<T> head)
        {
            if (head == null)
                return new Info(0, 0);

            Info dataLeft = Process(head.Left);
            Info dataRight = Process(head.Right);

            int height=Math.Max(dataLeft.Height,dataRight.Height)+1;
            int maxDistance=Math.Max(Math.Max(dataLeft.MaxDistance,dataRight.MaxDistance),dataLeft.Height+dataRight.Height+1);
           
            return new Info(maxDistance, height);
        }
    }
}
