using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class ShellSort
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int len = nums.Length;
            int currentValue;
            int gap = len / 2;
            while (gap > 0)
            {
                for (int i = gap; i < len; i++)
                {
                    currentValue = nums[i];
                    int preIndex = i - gap;
                    while (preIndex >= 0 && currentValue < nums[preIndex])
                    {
                        nums[preIndex + gap] = nums[preIndex];
                        preIndex -= gap;
                    }
                    nums[preIndex + gap] = currentValue;
                }
                Console.WriteLine($"本轮增量:{gap}排序后的数组");
                Common.PrintArray(nums);
                Console.WriteLine("--------------------");
                gap /= 2;
            }
            return nums;
        }
    }
}
