using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 01.03. URL化
    //URL化。编写一种方法，将字符串中的空格全部替换为%20。假定该字符串尾部有足够的空间存放新增字符，并且知道字符串的“真实”长度。（注：用Java实现的话，请使用字符数组实现，以便直接在数组上操作。）

    //示例 1：

    //输入："Mr John Smith    ", 13
    //输出："Mr%20John%20Smith"
    //示例 2：

    //输入："               ", 5
    //输出："%20%20%20%20%20"


    //提示：

    //字符串长度在[0, 500000] 范围内。
    public class Solution10
    {
        public string ReplaceSpaces1(string S, int length)
        {
            return S.Substring(0, length).Replace(" ", "%20");
        }

        public string ReplaceSpaces2(string S, int length)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = S.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                    chars[i] = '%';

                sb.Append(chars[i]);
            }
            string s = sb.ToString();
            return s.Replace("%", "%20");
        }
    }
}
