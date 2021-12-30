﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    139. 单词拆分
    //给你一个字符串 s 和一个字符串列表 wordDict 作为字典。请你判断是否可以利用字典中出现的单词拼接出 s 。

    //注意：不要求字典中出现的单词全部都使用，并且字典中的单词可以重复使用。



    //示例 1：

    //输入: s = "leetcode", wordDict = ["leet", "code"]
    //    输出: true
    //解释: 返回 true 因为 "leetcode" 可以由 "leet" 和 "code" 拼接成。
    //示例 2：

    //输入: s = "applepenapple", wordDict = ["apple", "pen"]
    //    输出: true
    //解释: 返回 true 因为 "applepenapple" 可以由 "apple" "pen" "apple" 拼接成。
    //     注意，你可以重复使用字典中的单词。
    //示例 3：

    //输入: s = "catsandog", wordDict = ["cats", "dog", "sand", "and", "cat"]
    //    输出: false


    //提示：

    //1 <= s.length <= 300
    //1 <= wordDict.length <= 1000
    //1 <= wordDict[i].length <= 20
    //s 和 wordDict[i] 仅有小写英文字母组成
    //wordDict 中的所有字符串 互不相同
    public class Solution88
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var wordDictSet = new HashSet<string>(wordDict);
            var dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 1; i <= s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && wordDictSet.Contains(s.Substring(j, i - j)))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
