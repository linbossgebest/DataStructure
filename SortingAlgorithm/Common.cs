using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public static class Common
    {
        public static void PrintArray(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < nums.Length; i++)
            {
                sb.Append(nums[i]);
                sb.Append(",");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
