using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    22. 括号生成
    //数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。

    //示例 1：

    //输入：n = 3
    //输出：["((()))","(()())","(())()","()(())","()()()"]
    //    示例 2：

    //输入：n = 1
    //输出：["()"]


    //    提示：

    //1 <= n <= 8
    public class Solution70
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> res = new List<string>();
            Process(res, "", 0, 0, n);
            return res;
        }
        public void Process(IList<string> res, string s, int left, int right, int n)
        {
            if (s.Length == n * 2)
            {
                res.Add(s);
                return;
            }
            if (left < n)
            {
                s += '(';
                Process(res, s, left + 1, right, n);
                s = s.Remove(s.Length - 1);
            }
            if (right < left)
            {
                s += ')';
                Process(res, s, left, right + 1, n);
                s = s.Remove(s.Length - 1);
            }
        }

        public IList<string> GenerateParenthesis1(int n)
        {
            IList<String> combinations = new List<string>();
            generateAll(new char[2 * n], 0, combinations);
            return combinations;
        }

        public void generateAll(char[] current, int pos, IList<string> result)
        {
            if (pos == current.Length)
            {
                //Console.WriteLine(new string(current));
                if (valid(current))
                {
                    result.Add(new string(current));
                }
            }
            else
            {
                current[pos] = '(';
                generateAll(current, pos + 1, result);
                current[pos] = ')';
                generateAll(current, pos + 1, result);
            }
        }

        public bool valid(char[] current)
        {
            int balance = 0;
            foreach (char c in current)
            {
                if (c == '(')
                {
                    ++balance;
                }
                else
                {
                    --balance;
                }
                if (balance < 0)
                {
                    return false;
                }
            }
            return balance == 0;
        }

    }
}
