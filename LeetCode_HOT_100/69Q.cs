using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    17. 电话号码的字母组合
    //给定一个仅包含数字 2-9 的字符串，返回所有它能表示的字母组合。答案可以按 任意顺序 返回。

    //给出数字到字母的映射如下（与电话按键相同）。注意 1 不对应任何字母。

    //2 abc
    //3 def
    //4 ghi
    //5 jkl
    //6 mno
    //7 pqrs
    //8 tvw
    //9 xyz

    //示例 1：

    //输入：digits = "23"
    //输出：["ad","ae","af","bd","be","bf","cd","ce","cf"]
    //    示例 2：

    //输入：digits = ""
    //输出：[]
    //    示例 3：

    //输入：digits = "2"
    //输出：["a","b","c"]


    //    提示：

    //0 <= digits.length <= 4
    //digits[i] 是范围['2', '9'] 的一个数字。
    public class Solution69
    {
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> res = new List<string>();
            if (digits.Length == 0)
                return res;

            Dictionary<char, string> dicNumString = new Dictionary<char, string>();
            dicNumString.Add('2', "abc");
            dicNumString.Add('3', "def");
            dicNumString.Add('4', "ghi");
            dicNumString.Add('5', "jkl");
            dicNumString.Add('6', "mno");
            dicNumString.Add('7', "pqrs");
            dicNumString.Add('8', "tuv");
            dicNumString.Add('9', "wxyz");
            Process(res, dicNumString, digits, 0, "");
            return res;
        }

        public void Process(IList<string> res, Dictionary<char, string> dicNumString, string digits, int index, string s)
        {
            if (index == digits.Length)
                res.Add(s);
            else
            {
                char digit = digits[index];
                string letters = dicNumString[digit];
                int lettersCount = letters.Length;
                for (int i = 0; i < lettersCount; i++)
                {
                    //s = s.Append(letters[i]);
                    s += letters[i];
                    Process(res, dicNumString, digits, index + 1, s);
                    s = s.Remove(index);
                }
            }
        }
    }
}
