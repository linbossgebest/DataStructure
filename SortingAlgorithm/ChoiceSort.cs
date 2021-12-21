using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class ChoiceSort
    {
        public int[] SortArray(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            for (int i = 0; i < nums.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                        minIndex = j;
                }
                int temp = nums[minIndex];
                nums[minIndex] = nums[i];
                nums[i] = temp;
            }
            return nums;
        }
    }
}
