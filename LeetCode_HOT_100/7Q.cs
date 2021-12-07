﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //7. 整数反转
    //给你一个 32 位的有符号整数 x ，返回将 x 中的数字部分反转后的结果。

    //如果反转后整数超过 32 位的有符号整数的范围[−231, 231 − 1] ，就返回 0。

    //假设环境不允许存储 64 位整数（有符号或无符号）。


    //示例 1：

    //输入：x = 123
    //输出：321
    //示例 2：

    //输入：x = -123
    //输出：-321
    //示例 3：

    //输入：x = 120
    //输出：21
    //示例 4：

    //输入：x = 0
    //输出：0


    //提示：

    //-2^31 <= x <= 2^31 - 1
    public class Solution7
    {
        public int Reverse(int x)
        {
            int res = 0;
            while (x != 0)
            {
                if (res < int.MinValue / 10 || res > int.MaxValue / 10)
                    return 0;
                int d = x % 10;
                x /= 10;
                res = res * 10 + d;
            }
            return res;
        }
    }
}
