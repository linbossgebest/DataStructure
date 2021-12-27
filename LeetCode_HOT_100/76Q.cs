using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    49. 字母异位词分组
    //给你一个字符串数组，请你将 字母异位词 组合在一起。可以按任意顺序返回结果列表。

    //字母异位词 是由重新排列源单词的字母得到的一个新单词，所有源单词中的字母通常恰好只用一次。



    //示例 1:

    //输入: strs = ["eat", "tea", "tan", "ate", "nat", "bat"]
    //    输出: [["bat"],["nat","tan"],["ate","eat","tea"]]
    //示例 2:

    //输入: strs = [""]
    //    输出: [[""]]
    //示例 3:

    //输入: strs = ["a"]
    //    输出: [["a"]]


    //提示：

    //1 <= strs.length <= 104
    //0 <= strs[i].length <= 100
    //strs[i] 仅包含小写字母
    public class Solution76
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();

            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] arrayChar = strs[i].ToArray();
                Array.Sort(arrayChar);
                string key = new string(arrayChar);
                if (dic.ContainsKey(key))
                {
                    dic[key].Add(strs[i]);
                }
                else
                {
                    List<string> value = new List<string>();
                    value.Add(strs[i]);
                    dic.Add(key, value);
                }              
            }
            foreach (var item in dic)
            {
                res.Add(item.Value);
            }
            return res;
        }
    }
}
