using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 01.05. 一次编辑
    //字符串有三种编辑操作:插入一个字符、删除一个字符或者替换一个字符。 给定两个字符串，编写一个函数判定它们是否只需要一次(或者零次)编辑。

    //示例 1:

    //输入: 
    //first = "pale"
    //second = "ple"
    //输出: True


    //示例 2:

    //输入: 
    //first = "pales"
    //second = "pal"
    //输出: False
    public class Solution12
    {
        public bool OneEditAway(string first, string second)
        {
            int lf = first.Length;
            int ls = second.Length;
            if (lf > ls)
                return OneEditAway(second, first);//长度小的在前 大的在后
            if (ls - lf > 1)
                return false;
            if (ls == lf)
            {
                int count = 0;
                for (int j = 0; j < ls; j++)
                {
                    if (first[j] != second[j])
                        count++;
                }
                return count <= 1;
            }
            int i = 0, off = 0;
            while (i < lf)
            {
                if (first[i] != second[i + off])
                {
                    if (++off > 1)
                        return false;
                }
                else
                    i++;
            }

            return true;
        }
    }
}
