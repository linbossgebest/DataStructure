using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    56. 合并区间
    //以数组 intervals 表示若干个区间的集合，其中单个区间为 intervals[i] = [starti, endi] 。请你合并所有重叠的区间，并返回一个不重叠的区间数组，该数组需恰好覆盖输入中的所有区间。



    //示例 1：

    //输入：intervals = [[1,3],[2,6],[8,10],[15,18]]
    //输出：[[1,6],[8,10],[15,18]]
    //解释：区间[1, 3] 和[2, 6] 重叠, 将它们合并为[1, 6].
    //示例 2：

    //输入：intervals = [[1,4],[4,5]]
    //输出：[[1,5]]
    //解释：区间[1, 4] 和[4, 5] 可被视为重叠区间。


    //提示：

    //1 <= intervals.length <= 104
    //intervals[i].length == 2
    //0 <= starti <= endi <= 104
    public class Solution78
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, new MyCompar());
            List<int[]> res = new List<int[]>();

            for (int i = 0; i < intervals.Length; i++)
            {
                int left = intervals[i][0], right = intervals[i][1];
                if (res.Count == 0 || res[res.Count - 1][1] < left)
                {
                    res.Add(new int[] { left, right });
                }
                else
                {
                    res[res.Count - 1][1] = Math.Max(right, res[res.Count - 1][1]);
                }
            }

            return res.ToArray();
        }

        public class MyCompar : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0] - y[0];
            }
        }
    }
}
