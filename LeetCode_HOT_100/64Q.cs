using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    461. 汉明距离
    //两个整数之间的 汉明距离 指的是这两个数字对应二进制位不同的位置的数目。

    //给你两个整数 x 和 y，计算并返回它们之间的汉明距离。



    //示例 1：

    //输入：x = 1, y = 4
    //输出：2
    //解释：
    //1   (0 0 0 1)
    //4   (0 1 0 0)
    //       ↑   ↑
    //上面的箭头指出了对应二进制位不同的位置。
    //示例 2：

    //输入：x = 3, y = 1
    //输出：1
    public class Solution64
    {
        public int HammingDistance(int x, int y)
        {
            return CountOne(x ^ y);
        }

        private int CountOne(int m)
        {
            int res = 0;

            while (m > 0)
            {
                if ((m & 1) == 1)
                    res++;
                m = m >> 1;
            }
            return res;
        }
    }
}
