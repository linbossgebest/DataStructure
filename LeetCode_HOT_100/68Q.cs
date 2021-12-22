using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    15. 三数之和
    //给你一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0 ？请你找出所有和为 0 且不重复的三元组。

    //注意：答案中不可以包含重复的三元组。

    //示例 1：

    //输入：nums = [-1,0,1,2,-1,-4]
    //    输出：[[-1,-1,2],[-1,0,1]]
    //示例 2：

    //输入：nums = []
    //    输出：[]
    //    示例 3：

    //输入：nums = [0]
    //    输出：[]


    //    提示：

    //0 <= nums.length <= 3000
    //-105 <= nums[i] <= 105
    public class Solution68
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            int len = nums.Length;
            if (nums.Length < 3 || nums == null)
                return res;
            Array.Sort(nums);//升序排序
            for (int i = 0; i < len; i++)
            {
                if (nums[i] > 0)//之后的数字没有可能和=0
                    break;
                if (i > 0 && nums[i] == nums[i - 1])//去重
                    continue;
                int l = i + 1;//左指针
                int r = len - 1;//右指针
                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum == 0)
                    {
                        List<int> templist = new List<int>();
                        templist.Add(nums[i]);
                        templist.Add(nums[l]);
                        templist.Add(nums[r]);
                        res.Add(templist);
                        while (l < r && nums[l] == nums[l + 1])//去重
                            l++;
                        while (l < r && nums[r] == nums[r - 1])//去重
                            r--;

                        l++;
                        r--;
                    }
                    else if (sum < 0)
                        l++;
                    else if (sum > 0)
                        r--;
                }

            }
            return res;

        }
    }
}
