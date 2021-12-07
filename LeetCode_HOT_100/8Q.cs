using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //题 01.01. 判定字符是否唯一
    //实现一个算法，确定一个字符串 s 的所有字符是否全都不同。

    //示例 1：

    //输入: s = "leetcode"
    //输出: false 
    //示例 2：

    //输入: s = "abc"
    //输出: true
    //限制：

    //0 <= len(s) <= 100
    //如果你不使用额外的数据结构，会很加分。
    public class Solution8
    {
        /// <summary>
        /// 暴力破解
        /// </summary>
        /// <param name="astr"></param>
        /// <returns></returns>
        public bool IsUnique1(string astr)
        {
            char[] arrC = astr.ToArray();
            for (int i = 0; i < arrC.Length; i++)
            {
                for (int j = i + 1; j < arrC.Length; j++)
                {
                    if (astr[i] == astr[j])
                        return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 使用额外hash结构
        /// </summary>
        /// <param name="astr"></param>
        /// <returns></returns>
        public bool IsUnique2(string astr)
        {
            char[] arrC = astr.ToArray();
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < arrC.Length; i++)
            {
                if (hs.Contains(arrC[i]))
                    return false;

                hs.Add(arrC[i]);
            }
            return true;
        }

        /// <summary>
        /// 位运算
        /// </summary>
        /// <param name="astr"></param>
        /// <returns></returns>
        public bool IsUnique3(string astr)
        {
            int mask = 0;
            for (int i = 0; i < astr.Length; i++)
            {
                int move = astr[i] - 'a';
                if ((mask & (1 << move)) != 0)
                    return false;
                else
                    mask = mask | (1 << move);
            }
            return true;
        }
    }
}
