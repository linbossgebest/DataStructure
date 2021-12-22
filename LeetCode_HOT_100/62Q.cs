using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    169. 多数元素
    //给定一个大小为 n 的数组，找到其中的多数元素。多数元素是指在数组中出现次数 大于 ⌊ n/2 ⌋ 的元素。

    //你可以假设数组是非空的，并且给定的数组总是存在多数元素。

    //示例 1：

    //输入：[3,2,3]
    //    输出：3
    //示例 2：

    //输入：[2,2,1,1,1,2,2]
    //    输出：2


    //进阶：

    //尝试设计时间复杂度为 O(n)、空间复杂度为 O(1) 的算法解决此问题。

    public class Solution62
    {
        /// <summary>
        /// 数组排序，多数元素即存在长度> ⌊ n/2 ⌋的一长串 由相同元素构成的连续子数组。
        /// 数组中间的元素总是“多数元素”，毕竟它长度> ⌊ n/2 ⌋。
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length >> 1];
        }

        public int MajorityElement1(int[] nums)
        {
            int res = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (dic.ContainsKey(nums[i]))
                    dic[nums[i]]++;
                else
                    dic.Add(nums[i], 1);
            }
            foreach (var item in dic)
            {
                if (item.Value > nums.Length / 2)
                    res= item.Key;
            }
            return res;
        }
    }
}
