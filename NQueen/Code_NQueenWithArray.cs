using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    /// <summary>
    /// n皇后问题（使用数组处理）
    /// </summary>
    public static class Code_NQueenWithArray
    {
        public static int Num(int n)
        {
            if (n < 1)
                return 0;

            int[] record = new int[n];//index=> i行  value=> j列
            return Process(0, record, n);
        }

        /// <summary>
        /// 递归处理
        /// </summary>
        /// <param name="i">当前所在的i行</param>
        /// <param name="record">record[0...i-1] 记录所有在i行之前符合条件的 皇后</param>
        /// <param name="n">总共多少行</param>
        /// <returns></returns>
        public static int Process(int i, int[] record, int n)
        {
            if (i == n)//=> i已经走到最后一行的下一行，找到一个n皇后满足条件
            {
                return 1;
            }
            int res = 0;
            for (int j = 0; j < n; j++)//j => 所在列
            {
                if (IsValid(record, i, j))
                {
                    record[i] = j;
                    res += Process(i + 1, record, n);
                }
            }
            return res;
        }

        /// <summary>
        /// 判断是否满足条件
        /// </summary>
        /// <param name="record">所有在i行之前符合条件的 皇后</param>
        /// <param name="i">当前i行</param>
        /// <param name="j">当前j列</param>
        /// <returns></returns>
        public static bool IsValid(int[] record, int i, int j)
        {
            for (int k = 0; k < i; k++)
            {
                //(和i行之前的任一皇后在同一列 || 和i行之前的任一皇后斜率相同) 则不满n皇后条件
                if (j == record[k] || Math.Abs(j - record[k]) == Math.Abs(i - k))
                    return false;
            }
            return true;
        }
    }
}
