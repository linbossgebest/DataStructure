using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public static class Code_MaxBST
    {
        public static int MaxSubBSTSize(Node<int> head)
        {
            if (head == null)
                return 0;

            return Process(head).MaxSubBSTSize;
        }

        private class Info
        {
            public bool IsBST { get; set; }
            public int MaxSubBSTSize { get; set; }
            public int Min { get; set; }
            public int Max { get; set; }

            public Info(bool isBST, int maxSubBSTSize, int min, int max)
            {
                IsBST = isBST;
                MaxSubBSTSize = maxSubBSTSize;
                Min = min;
                Max = max;
            }
        }

        private static Info Process(Node<int> head)
        {
            if (head == null)
                return null;

            Info dataLeft = Process(head.Left);
            Info dataRight = Process(head.Right);

            int min = head.Data;
            int max = head.Data;
            int maxSubBSTSize = 0;
            bool isBST = false;

            if (dataLeft != null)
            {
                min = dataLeft.Min;
                max = dataLeft.Max;
                maxSubBSTSize = dataLeft.MaxSubBSTSize;
            }
            if (dataRight != null)
            {
                min = dataRight.Min;
                max = dataRight.Max;
                maxSubBSTSize = Math.Max(dataRight.MaxSubBSTSize, dataLeft.MaxSubBSTSize);
            }

            if ((dataLeft != null ? true : dataLeft.IsBST)
                && (dataRight != null ? true : dataRight.IsBST)
                && (dataLeft != null ? true : dataLeft.Max < head.Data)
                && (dataRight != null ? true : dataRight.Min > head.Data))
            {
                isBST = true;
                maxSubBSTSize = (dataLeft != null ? 0 : dataLeft.MaxSubBSTSize) + (dataRight != null ? 0 : dataRight.MaxSubBSTSize) + 1;
            }

            return new Info(isBST, maxSubBSTSize, min,max);

        }
    }
}
