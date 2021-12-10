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

        /// <summary>
        /// 记忆搜索
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="aim"></param>
        /// <returns></returns>
        public static int MinCoin2(int[] arr, int aim)
        {
            int N = arr.Length;
            int[,] dp = new int[N + 1, aim + 1];
            for (int index = 0; index <= N; index++)
            {
                for (int rest = 0; rest <= aim; rest++)
                    dp[index, rest] = -2;
            }
            return f2(arr, 0, aim, dp);
        }

        /// <summary>
        /// 记忆搜索
        /// </summary>
        /// <param name="arr">硬币数组</param>
        /// <param name="index"></param>
        /// <param name="rest"></param>
        /// <returns></returns>
        public static int f2(int[] arr, int index, int rest, int[,] dp)
        {
            if (rest < 0)
                return -1;
            if (dp[index, rest] != -2)
                return dp[index, rest];

            if (rest == 0)
            {
                dp[index, rest] = 0;
            }
            //rest>0的情况
            else if (index == arr.Length)//没有硬币，但是rest>0 说明没有成立条件
            {
                dp[index, rest] = -1;
            }
            else
            {
                int p1 = f2(arr, index + 1, rest, dp);//不使用index 位置货币的情况 rest没变
                int p2 = f2(arr, index + 1, rest - arr[index], dp);//使用index 位置货币 rest= rest-arr[index]
                if (p1 == -1 && p2 == -1)
                {
                    dp[index, rest] = -1;
                }
                else
                {
                    if (p1 == -1)
                        dp[index, rest] = p2 + 1;
                    else if (p2 == -1)
                        dp[index, rest] = p1;
                    else
                        dp[index, rest] = Math.Min(p1, p2 + 1);
                }
            }
            return dp[index, rest];
        }

        /// <summary>
        /// 严格表结构（动态规划）
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="aim"></param>
        /// <returns></returns>
        public static int MinCoin3(int[] arr, int aim)
        {
            int N = arr.Length;
            int[,] dp = new int[N + 1, aim + 1];

            for (int index = 0; index <= N; index++)
                dp[index, 0] = 0;
            for (int rest = 1; rest <= aim; rest++)
                dp[N, rest] = -1;

            for (int index = N - 1; index >= 0; index--)
            {
                for (int rest = 1; rest <= aim; rest++)
                {

                    int p1 = dp[index + 1, rest];
                    int p2 = -1;
                    if (rest - arr[index] >= 0)
                        p2 = dp[index + 1, rest - arr[index]];
                    if (p1 == -1 && p2 == -1)
                    {
                        dp[index, rest] = -1;
                    }
                    else
                    {
                        if (p1 == -1)
                            dp[index, rest] = p2 + 1;
                        else if (p2 == -1)
                            dp[index, rest] = p1;
                        else
                            dp[index, rest] = Math.Min(p1, p2 + 1);
                    }
                }
            }
            return dp[0, aim];
        }



        public static int[] GenerateRandomArray(int len, int max)
        {
            Random rd = new Random();
            int[] arr = new int[rd.Next(1, 2) * len + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(max) + 1;
            }
            return arr;
        }

        public static void Test()
        {
            int len = 10;
            int max = 10;
            int testTime = 10000;
            for (int i = 0; i < testTime; i++)
            {
                int[] arr = GenerateRandomArray(len, max);
                int aim = new Random().Next(50);
                if (MinCoin1(arr, aim) != MinCoin2(arr, aim) || MinCoin2(arr, aim) != MinCoin3(arr, aim))
                {
                    Console.WriteLine("结果不一致");
                    break;
                }
            }
            Console.WriteLine("数据一致");
        }
    }
}
