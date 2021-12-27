﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    39. 组合总和
    //给你一个 无重复元素 的整数数组 candidates 和一个目标整数 target ，找出 candidates 中可以使数字和为目标数 target 的 所有不同组合 ，并以列表形式返回。你可以按 任意顺序 返回这些组合。

    //candidates 中的 同一个 数字可以 无限制重复被选取 。如果至少一个数字的被选数量不同，则两种组合是不同的。 

    //对于给定的输入，保证和为 target 的不同组合数少于 150 个。

    //示例 1：

    //输入：candidates = [2,3,6,7], target = 7
    //输出：[[2,2,3],[7]]
    //解释：
    //2 和 3 可以形成一组候选，2 + 2 + 3 = 7 。注意 2 可以使用多次。
    //7 也是一个候选， 7 = 7 。
    //仅有这两种组合。
    //示例 2：

    //输入: candidates = [2,3,5], target = 8
    //输出: [[2,2,2,2],[2,3,3],[3,5]]
    //示例 3：

    //输入: candidates = [2], target = 1
    //输出: []
    //    示例 4：

    //输入: candidates = [1], target = 1
    //输出: [[1]]
    //示例 5：

    //输入: candidates = [1], target = 2
    //输出: [[1,1]]


    //提示：

    //1 <= candidates.length <= 30
    //1 <= candidates[i] <= 200
    //candidate 中的每个元素都 互不相同
    //1 <= target <= 500
    public class Solution74
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            List<int> temp = new List<int>();
            Process(candidates, target, res, temp, 0);
            return res;
        }

        public void Process(int[] candidates, int target, IList<IList<int>> res, List<int> temp,int index)
        {
            if (index == candidates.Length)
                return;

            if (target == 0) 
            {
                res.Add(new List<int>(temp));
                return;
            }

            Process(candidates, target, res, temp, index + 1);
            if (target - candidates[index] >= 0)
            {
                temp.Add(candidates[index]);
                Process(candidates, target - candidates[index], res, temp, index);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}
