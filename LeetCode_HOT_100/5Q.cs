using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //5. 最长回文子串
    //给你一个字符串 s，找到 s 中最长的回文子串。



    //示例 1：

    //输入：s = "babad"
    //输出："bab"
    //解释："aba" 同样是符合题意的答案。
    //示例 2：

    //输入：s = "cbbd"
    //输出："bb"
    //示例 3：

    //输入：s = "a"
    //输出："a"
    //示例 4：

    //输入：s = "ac"
    //输出："a"


    //提示：

    //1 <= s.length <= 1000
    //s 仅由数字和英文字母（大写和/或小写）组成
    public class Solution5
    {
        public string LongestPalindrome(string s)
        {
            return MaxPalindromeLength(s);
        }

        private char[] ManacherString(string s)
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
        /// 返回最长的回文子串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string MaxPalindromeLength(string s)
        {
            if (s == null || s.Length == 0)
                return "";

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
                //max = Math.Max(max, pArr[i]);
            }
            int maxLen = 0;
            int centerIndex = 0;
            for (int i = 0; i < pArr.Length; i++)
            {
                if (pArr[i] > maxLen) {
                    maxLen = pArr[i];
                    centerIndex = i;
                }
            }
            //maxLen-1 最大回文长度=最大回文半径-1
            int startIndex = (centerIndex - (maxLen-1)) / 2;//原始字符串s的开始下标
            return s.Substring(startIndex,maxLen-1);
        }
    }
}
