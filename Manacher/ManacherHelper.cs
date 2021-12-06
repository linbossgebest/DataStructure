using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manacher
{
    public static class ManacherHelper
    {
        /// <summary>
        /// 将字符串转化为加特殊字符的 字符串
        ///      1221
        /// =>   #1#2#2#1#1
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static char[] ManacherString(string s)
        {
            char[] charArr = s.ToCharArray();
            char[] res = new char[charArr.Length * 2 + 1];
            int index = 0;
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = (i & 1) == 0 ? '#' : charArr[index++];
            }
            return res;
        }

        /// <summary>
        /// 获取最大回文长度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxPalindromeLength(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            char[] str = ManacherString(s);
            int[] pArr = new int[str.Length];//回文半径数组
            int R = -1; //当前回文右边界的再往右一个位置，最右的有效区是R-1位置
            int C = -1; //当前回文中心位置
            int max = int.MinValue;//扩出来的最大值
            for (int i = 0; i < pArr.Length; i++)
            {
                //i位置最小的回文半径
                pArr[i] = R > i ? Math.Min(pArr[2 * C - i], R - i) : 1;
                while (i + pArr[i] < str.Length && i - pArr[i] > -1)//i位置往左扩不会超过边界  i位置往右找值和左扩比对不会超边界
                {
                    if (str[i + pArr[i]] == str[i - pArr[i]])//右扩位置的值与左边对称位置的值相等，则该位置的回文半径+1
                        pArr[i]++;
                    else//如果不相等，直接break 
                        break;                    
                }
                if (i + pArr[i] > R)//如果当前i位置的回文半径超过边界R，R向右扩；i作为C中心位置
                {
                    R = i + pArr[i];
                    C = i;
                }
                max = Math.Max(max, pArr[i]);
            }
            return max - 1;//最大回文长度=最大回文半径-1
        }
    }
}
