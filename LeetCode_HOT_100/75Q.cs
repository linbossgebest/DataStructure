using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    46. 全排列
    //给定一个不含重复数字的数组 nums ，返回其 所有可能的全排列 。你可以 按任意顺序 返回答案。



    //示例 1：

    //输入：nums = [1,2,3]
    //    输出：[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
    //示例 2：

    //输入：nums = [0,1]
    //    输出：[[0,1],[1,0]]
    //示例 3：

    //输入：nums = [1]
    //    输出：[[1]]


    //提示：

    //1 <= nums.length <= 6
    //-10 <= nums[i] <= 10
    //nums 中的所有整数 互不相同
    public class Solution75
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            int len = nums.Length;
            IList<IList<int>> res = new List<IList<int>>();

            if (len == 0)
                return res;

            bool[] used = new bool[len];
            List<int> temp = new List<int>();

            Process(nums, len, 0, temp, used, res);
            return res;
        }

        public void Process(int[] nums, int len, int index, List<int> temp, bool[] used, IList<IList<int>> res)
        {
            if (index == len)
            {
                res.Add(new List<int>(temp));
                return;
            }

            for (int i = 0; i < len; i++)
            {
                if (!used[i])
                {
                    temp.Add(nums[i]);
                    used[i] = true;
                    Console.WriteLine("  递归之前 => " + string.Join(",", temp.ToArray()));
                    Process(nums, len, index + 1,temp, used, res);
                    used[i] = false;
                    temp.RemoveAt(temp.Count - 1);
                    Console.WriteLine("递归之后 => " + string.Join(",", temp.ToArray()));
                }
            }
        }
    }
}
