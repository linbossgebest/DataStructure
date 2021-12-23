using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{

    //    31. 下一个排列
    //实现获取 下一个排列 的函数，算法需要将给定数字序列重新排列成字典序中下一个更大的排列（即，组合出下一个更大的整数）。

    //如果不存在下一个更大的排列，则将数字重新排列成最小的排列（即升序排列）。

    //必须 原地 修改，只允许使用额外常数空间。

    //示例 1：

    //输入：nums = [1,2,3]
    //    输出：[1,3,2]
    //    示例 2：

    //输入：nums = [3,2,1]
    //    输出：[1,2,3]
    //    示例 3：

    //输入：nums = [1,1,5]
    //    输出：[1,5,1]
    //    示例 4：

    //输入：nums = [1]
    //    输出：[1]


    //    提示：

    //1 <= nums.length <= 100
    //0 <= nums[i] <= 100
    public class Solution71
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1]) //数组从后往前找到第一个升序索引
                i--;
            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[i] >= nums[j])//数组从后往前找到第一个比nums[i]大的索引
                    j--;

                Swap(nums, i, j);
            }
            Reverse(nums, i + 1);
        }

        public void Swap(int[] nums, int i, int j)
        {
            var temp = nums[j];
            nums[j] = nums[i];
            nums[i] = temp;
        }

        public void Reverse(int[] nums, int start)
        {
            int left = start;
            int right = nums.Length - 1;
            while (left < right)
            {
                Swap(nums, left, right);
                left++;
                right--;
            }
        }
    }
}
