using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //4. 寻找两个正序数组的中位数
    //给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。

    //算法的时间复杂度应该为 O(log (m+n)) 。



    //示例 1：

    //输入：nums1 = [1,3], nums2 = [2]
    //    输出：2.00000
    //解释：合并数组 = [1,2,3] ，中位数 2
    //示例 2：

    //输入：nums1 = [1,2], nums2 = [3,4]
    //    输出：2.50000
    //解释：合并数组 = [1,2,3,4] ，中位数(2 + 3) / 2 = 2.5
    //示例 3：

    //输入：nums1 = [0,0], nums2 = [0,0]
    //    输出：0.00000
    //示例 4：

    //输入：nums1 = [], nums2 = [1]
    //    输出：1.00000
    //示例 5：

    //输入：nums1 = [2], nums2 = []
    //    输出：2.00000


    //提示：

    //nums1.length == m
    //nums2.length == n
    //0 <= m <= 1000
    //0 <= n <= 1000
    //1 <= m + n <= 2000
    //-106 <= nums1[i], nums2[i] <= 106
    public class Solution4
    {
        /// <summary>
        /// 暴力破解法
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays1(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            int[] nums = new int[n1 + n2];
            Array.Copy(nums1, 0, nums, 0, n1);
            Array.Copy(nums2, 0, nums, n1, n2);
            Array.Sort(nums);
            int n = nums.Length;
            if ((n & 1) == 0)
                return (nums[n / 2] + nums[(n / 2) - 1]) / 2.0;
            else
                return nums[n / 2];
        }

        /// <summary>
        /// 比较一半数组
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            int len = n1 + n2;
            int left = -1, right = -1;
            int n1Start = 0, n2Start = 0;
            for (int i = 0; i <= len / 2; i++)
            {
                left = right;
                if (n1Start < n1 && (n2Start >= n2 || nums1[n1Start] < nums2[n2Start]))
                {
                    right = nums1[n1Start++];
                }
                else
                {
                    right = nums2[n2Start++];
                }
            }
            if ((len & 1) == 0)
                return (left + right) / 2.0;
            else
                return right;
        }

        //public double FindMedianSortedArrays3(int[] nums1, int[] nums2)
        //{
        //}
    }
}
