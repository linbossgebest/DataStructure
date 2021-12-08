using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 01.09. 字符串轮转
    //字符串轮转。给定两个字符串s1和s2，请编写代码检查s2是否为s1旋转而成（比如，waterbottle是erbottlewat旋转后的字符串）。

    //示例1:

    // 输入：s1 = "waterbottle", s2 = "erbottlewat"
    // 输出：True
    //示例2:

    // 输入：s1 = "aa", s2 = "aba"
    // 输出：False
    //提示：

    //字符串长度在[0, 100000] 范围内。
    //说明:

    //你能只调用一次检查子串的方法吗？
    public class Solution16
    {
        public bool IsFlipedString(string s1, string s2)
        {
            if (s1 == null || s2 == null || s1?.Length != s2?.Length)
                return false;

            if ((s2 + s2).Contains(s1))
                return true;

            return false;
        }
    }
}
