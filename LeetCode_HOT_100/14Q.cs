using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 01.07. 旋转矩阵
    //给你一幅由 N × N 矩阵表示的图像，其中每个像素的大小为 4 字节。请你设计一种算法，将图像旋转 90 度。

    //不占用额外内存空间能否做到？

    //示例 1:

    //给定 matrix =
    //[
    //  [1, 2, 3],
    //  [4, 5, 6],
    //  [7, 8, 9]
    //],

    //原地旋转输入矩阵，使其变为:
    //[
    //  [7,4,1],
    //  [8,5,2],
    //  [9,6,3]
    //]
    //示例 2:

    //给定 matrix =
    //[
    //  [5,  1,  9,  11],
    //  [2,  4,  8,  10],
    //  [13, 3,  6,   7],
    //  [15, 14, 12, 16]
    //], 

    //原地旋转输入矩阵，使其变为:
    //[
    //  [15,13, 2, 5],
    //  [14, 3, 4, 1],
    //  [12, 6, 8, 9],
    //  [16, 7,10,11]
    //]
    //注意：本题与主站 48 题相同：https://leetcode-cn.com/problems/rotate-image/
    public class Solution14
    {
        public void Rotate(int[][] matrix)
        {
            int a = 0;
            int b = 0;
            int c = matrix.Length - 1;
            int d = matrix[0].Length - 1;
            while (a < c)
            {
                RotateEdge(matrix, a, b, c, d);
            }

        }

        private void RotateEdge(int[][] matrix, int a, int b, int c, int d)
        {
            int temp = 0;
            for (int i = 0; i < d - b; i++)
            {
                temp = matrix[a][b + i];
                matrix[a][b + i] = matrix[c - i][b];
                matrix[c - i][b] = matrix[c][d - i];
                matrix[c][d - i] = matrix[a + i][d];
                matrix[a + i][d] = temp;
            }
        }
    }
}
