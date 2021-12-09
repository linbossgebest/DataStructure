using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 01.02. 判定是否互为字符重排
    //给定两个字符串 s1 和 s2，请编写一个程序，确定其中一个字符串的字符重新排列后，能否变成另一个字符串。

    //示例 1：

    //输入: s1 = "abc", s2 = "bca"
    //输出: true 
    //示例 2：

    //输入: s1 = "abc", s2 = "bad"
    //输出: false
    //说明：

    //0 <= len(s1) <= 100
    //0 <= len(s2) <= 100
    public class Solution9
    {
        /// <summary>
        /// 字典表过滤
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool CheckPermutation1(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return false;
            if (s1.Length != s2.Length)
                return false;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                int total;
                if (!dic.TryGetValue(s1[i], out total))
                    total = 0;
                dic[s1[i]] = total + 1;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                int total;
                if (!dic.TryGetValue(s2[i], out total))
                    return false;
                else
                    dic[s2[i]] = total - 1;
            }

            foreach (var item in dic)
            {
                if (item.Value != 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 桶计数
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public bool CheckPermutation2(string s1, string s2)
        {
            if (s1 == null || s2 == null)
                return false;
            if (s1.Length != s2.Length)
                return false;

            var b1 = Bucket(s1);
            var b2 = Bucket(s2);
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i])
                    return false;
            }

            return true;
        }

        private int[] Bucket(string s)
        {
            int[] b = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                b[s[i] - 'a']++;
            }
            return b;
        }
    }
}
