using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    70. 爬楼梯
    //假设你正在爬楼梯。需要 n 阶你才能到达楼顶。

    //每次你可以爬 1 或 2 个台阶。你有多少种不同的方法可以爬到楼顶呢？

    //注意：给定 n 是一个正整数。

    //示例 1：

    //输入： 2
    //输出： 2
    //解释： 有两种方法可以爬到楼顶。
    //1.  1 阶 + 1 阶
    //2.  2 阶
    //示例 2：

    //输入： 3
    //输出： 3
    //解释： 有三种方法可以爬到楼顶。
    //1.  1 阶 + 1 阶 + 1 阶
    //2.  1 阶 + 2 阶
    //3.  2 阶 + 1 阶
    public class Solution37
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        public int ClimbStairs(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;

            if (dic.ContainsKey(n))
                return dic[n];
            else
            {
                int result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
                dic.Add(n, result);
                return result;
            }

        }

        public int ClimbStairs1(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            int result = 0;
            int pre = 2;
            int prepre = 1;
            for (int i = 3; i <= n; i++)
            {
                result = pre + prepre;
                prepre = pre;
                pre = result;
            }

            return result;
        }
    }
}
