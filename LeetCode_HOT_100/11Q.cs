using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 01.04. 回文排列
    //给定一个字符串，编写一个函数判定其是否为某个回文串的排列之一。

    //回文串是指正反两个方向都一样的单词或短语。排列是指字母的重新排列。

    //回文串不一定是字典当中的单词。



    //示例1：

    //输入："tactcoa"
    //输出：true（排列有"tacocat"、"atcocta"，等等）

    public class Solution11
    {
        public bool CanPermutePalindrome(string s)
        {
            if (s == null)
                return false;
            
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                    dic[s[i]]++;
                else
                    dic.Add(s[i], 1);
            }
                

            int odd = 0;

            foreach (var item in dic)
            {
                if (item.Value % 2 != 0)
                    odd++;

                if (odd > 1)
                    return false;
            }

            return true;
        }
    }
}
