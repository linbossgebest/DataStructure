using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    394. 字符串解码
    //给定一个经过编码的字符串，返回它解码后的字符串。

    //编码规则为: k[encoded_string]，表示其中方括号内部的 encoded_string 正好重复 k 次。注意 k 保证为正整数。

    //你可以认为输入字符串总是有效的；输入字符串中没有额外的空格，且输入的方括号总是符合格式要求的。

    //此外，你可以认为原始数据不包含数字，所有的数字只表示重复的次数 k ，例如不会出现像 3a 或 2[4] 的输入。



    //示例 1：

    //输入：s = "3[a]2[bc]"
    //输出："aaabcbc"
    //示例 2：

    //输入：s = "3[a2[c]]"
    //输出："accaccacc"
    //示例 3：

    //输入：s = "2[abc]3[cd]ef"
    //输出："abcabccdcdcdef"
    //示例 4：

    //输入：s = "abc3[cd]xyz"
    //输出："abccdcdcdxyz"
    //通过次数132,071提交次数238,390
    public class Solution49
    {
        public string DecodeString(string s)
        {
            Stack<string> charStack = new Stack<string>();
            Stack<int> numStack = new Stack<int>();
            //char[] chars = s.ToArray();
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                char cur = s[i];
                if (Char.IsDigit(cur))
                {
                    int num = GetIntNum(s, ref i);
                    numStack.Push(num);
                }
                else if (cur == '[')
                {
                    charStack.Push(res);
                    res = "";
                }
                else if (cur == ']')
                {
                    StringBuilder sbTemp;
                    if (charStack.Count > 0)
                    {
                        sbTemp = new StringBuilder(charStack.Pop());
                    }
                    else
                        sbTemp = new StringBuilder();

                    int repeatTimes = numStack.Pop();
                    while (repeatTimes > 0)
                    {
                        sbTemp.Append(res);
                        repeatTimes--;
                    }
                    res = sbTemp.ToString();
                }
                else
                {
                    res += s[i];
                }
            }

            return res;

        }

        private int GetIntNum(string s, ref int i)
        {
            StringBuilder sb = new StringBuilder();
            int tempNums = 0;
            for (int j = i; j < s.Length; j++)
            {         
                if (Char.IsDigit(s[j]))
                {
                    sb.Append(s[j]);
                    tempNums++;
                    i++;
                }
                else
                    break;
            }
            i--;
            return Int32.Parse(sb.ToString());
        }
    }
}
