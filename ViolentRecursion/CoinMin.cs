using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolentRecursion
{
    /// <summary>
    /// 最少硬币组成问题
    /// </summary>
    public class CoinMin
    {
        //arr[....] 数组中存在各种大小的硬币，
        //aim目标值 需要数组中的硬币组成=aim的值
        //Q：求解最少的硬币数量？

        public static int MinCoin1(int[] arr, int aim)
        {
            return f1(arr, 0, aim);
        }

        /// <summary>
        /// 暴力递归
        /// </summary>
        /// <param name="arr">硬币数组</param>
        /// <param name="index"></param>
        /// <param name="rest"></param>
        /// <returns></returns>
        public static int f1(int[] arr, int index, int rest)
        {
            if (rest < 0)
                return -1;

            if (rest == 0)
                return 0;

            //rest>0的情况
            if (index == arr.Length)//没有硬币，但是rest>0 说明没有成立条件
                return -1;

            int p1 = f1(arr, index + 1, rest);//不使用index 位置货币的情况 rest没变
            int p2 = f1(arr, index + 1, rest - arr[index]);//使用index 位置货币 rest= rest-arr[index]
            if (p1 == -1 && p2 == -1)
            {
                return -1;
            }
            else 
            {
                if (p1 == -1)
                    return p2 + 1;
                if (p2 == -1)
                    return p1;
                else
                    return Math.Min(p1, p2 + 1);
            }
        }

        public static int[] GenerateRandomArray(int len, int max)
        {
            Random rd = new Random();
            int[] arr = new int[rd.Next(1) * len + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(max) + 1;
            }
            return arr;
        }

        public static void TestCase()
        {
            int len = 10;
            int max = 10;
            int testTime = 10000;
            for (int i = 0; i < testTime; i++)
            {
                int[] arr = GenerateRandomArray(len, max);
                //todo test
            }
        }
    }
}
