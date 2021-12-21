using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class InsertionSort
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int currentValue;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int preIndex = i;//已被排序的索引
                currentValue = nums[preIndex + 1];
                while (preIndex >= 0 && currentValue < nums[preIndex])
                {
                    nums[preIndex + 1] = nums[preIndex];
                    preIndex--;
                }
                nums[preIndex + 1] = currentValue;
            }
            return nums;
        }
    }
}
