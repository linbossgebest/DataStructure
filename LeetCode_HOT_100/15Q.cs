using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 01.08. 零矩阵
    //编写一种算法，若M × N矩阵中某个元素为0，则将其所在的行与列清零。

    //示例 1：

    //输入：
    //[
    //  [1,1,1],
    //  [1,0,1],
    //  [1,1,1]
    //]
    //输出：
    //[
    //  [1,0,1],
    //  [0,0,0],
    //  [1,0,1]
    //]
    //示例 2：

    //输入：
    //[
    //  [0,1,2,0],
    //  [3,4,5,2],
    //  [1,3,1,5]
    //]
    //输出：
    //[
    //  [0,0,0,0],
    //  [0,4,5,0],
    //  [0,3,1,0]
    //]
    public class Solution15
    {
        public void SetZeroes(int[][] matrix)
        {
            int r = matrix.Length;
            int c = matrix[0].Length;
            bool[] row =new bool[r];
            bool[] col = new bool[c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    if (matrix[i][j] == 0)
                        row[i] = col[j] = true;
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    if (row[i] || col[j])
                        matrix[i][j] = 0;
            }

        }
    }
}
