using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    79. 单词搜索
    //给定一个 m x n 二维字符网格 board 和一个字符串单词 word 。如果 word 存在于网格中，返回 true ；否则，返回 false 。

    //单词必须按照字母顺序，通过相邻的单元格内的字母构成，其中“相邻”单元格是那些水平相邻或垂直相邻的单元格。同一个单元格内的字母不允许被重复使用。



    //示例 1：


    //输入：board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
    //输出：true
    //示例 2：


    //输入：board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "SEE"
    //输出：true
    //示例 3：


    //输入：board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCB"
    //输出：false


    //提示：

    //m == board.length
    //n = board[i].length
    //1 <= m, n <= 6
    //1 <= word.length <= 15
    //board 和 word 仅由大小写英文字母组成


    public class Solution83
    {
        public bool Exist(char[][] board, string word)
        {
            int rows = board.Length;
            int columns = board[0].Length;
            bool[][] visited = new bool[rows][];
            for (int i = 0; i < rows; i++)
            {
                visited[i] = new bool[columns];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    bool flag= Check(board,visited,i,j,word,0);
                    if (flag)
                        return true;
                }
            }
            return false;
        }

        public bool Check(char[][] board, bool[][] visited, int i, int j, string s, int k)
        {
            if (board[i][j] != s[k])
                return false;
            else if (k == s.Length - 1)
                return true;

            visited[i][j] = true;
            int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            bool res = false;
            for (int m = 0; m < directions.Length; m++)
            {
                int newi = i + directions[m][0];
                int newj = j + directions[m][1];
                if (newi >= 0 && newi < board.Length && newj >= 0 && newj < board[0].Length)
                {
                    if (!visited[newi][newj])
                    {
                        bool flag = Check(board, visited, newi, newj, s, k + 1);
                        if (flag)
                        {
                            res = true;
                            break;
                        }
                    }
                }
            }
            visited[i][j] = false;
            return res;
        }
    }
}
