using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    20. 有效的括号
    //给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。

    //有效字符串需满足：

    //左括号必须用相同类型的右括号闭合。
    //左括号必须以正确的顺序闭合。


    //示例 1：

    //输入：s = "()"
    //输出：true
    //示例 2：

    //输入：s = "()[]{}"
    //输出：true
    //示例 3：

    //输入：s = "(]"
    //输出：false
    //示例 4：

    //输入：s = "([)]"
    //输出：false
    //示例 5：

    //输入：s = "{[]}"
    //输出：true


    //提示：

    //1 <= s.length <= 104
    //s 仅由括号 '()[]{}' 组成
    public class Solution58
    {
        public bool IsValid(string s)
        {
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    charStack.Push(')');
                if (s[i] == '[')
                    charStack.Push(']');
                if (s[i] == '{')
                    charStack.Push('}');

                if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if (charStack.Count <= 0 || charStack.Pop() != s[i])
                        return false;
                }

            }
            return charStack.Count <= 0;
        }
    }
}
