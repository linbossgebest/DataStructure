using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    78. 子集
    //给你一个整数数组 nums ，数组中的元素 互不相同 。返回该数组所有可能的子集（幂集）。

    //解集 不能 包含重复的子集。你可以按 任意顺序 返回解集。



    //示例 1：

    //输入：nums = [1,2,3]
    //    输出：[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
    //示例 2：

    //输入：nums = [0]
    //    输出：[[],[0]]


    //提示：

    //1 <= nums.length <= 10
    //-10 <= nums[i] <= 10
    //nums 中的所有元素 互不相同
    public class Solution82
    {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> tempList = new List<int>();
        public IList<IList<int>> Subsets(int[] nums)
        {
            Process(nums, 0);
            return res;
        }

        public void Process(int[] nums, int index)
        {
            if (index == nums.Length)
            {
                res.Add(new List<int>(tempList));
                return;
            }
            tempList.Add(nums[index]);
            Process(nums, index + 1);
            tempList.RemoveAt(tempList.Count-1);
            Process(nums, index + 1);
        }
    }
}
