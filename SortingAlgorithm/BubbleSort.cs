using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j + 1] > nums[j])
                    {
                        var temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
        
    }
}
