using System;
using System.Collections.Generic;

namespace DoubleEndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = GetMaxWindow(arr, 3);
        }

        /// <summary>
        /// 最大窗口问题
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="w"></param>
        /// <returns></returns>
        public static int[] GetMaxWindow(int[] arr, int w)
        {
            if (arr == null || w < 1 || arr.Length < w)
                return null;

            LinkedList<int> maxQueue = new LinkedList<int>();//保持数据 大 ---> 小
            int[] res = new int[arr.Length - w + 1];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)//R指针移动
            {
                while (maxQueue.Count > 0 && arr[maxQueue.Last.Value] <= arr[i])
                {
                    maxQueue.RemoveLast();
                }
                maxQueue.AddLast(i);
                if (maxQueue.First.Value == i - w)//L指针移动
                {
                    maxQueue.RemoveFirst();
                }
                if (i >= w - 1)
                {
                    res[index++] = arr[maxQueue.First.Value];
                }
            }
            return res;
        }
    }
}
