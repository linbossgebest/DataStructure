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

                Console.WriteLine($"待排序元素索引：{i+1},值为：{currentValue},已被排序的索引：{preIndex}");

                while (preIndex >= 0 && currentValue < nums[preIndex])
                {
                    nums[preIndex + 1] = nums[preIndex];
                    preIndex--;
                    Common.PrintArray(nums);
                }
                nums[preIndex + 1] = currentValue;
                Console.WriteLine("本轮被插入排序的数组");
                Common.PrintArray(nums);
                Console.WriteLine("--------------------");
            }
            return nums;
        }
    }
}
