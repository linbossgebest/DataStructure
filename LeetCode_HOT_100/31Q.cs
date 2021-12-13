using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 04.01. 节点间通路
    //节点间通路。给定有向图，设计一个算法，找出两个节点之间是否存在一条路径。

    //示例1:

    // 输入：n = 3, graph = [[0, 1], [0, 2], [1, 2], [1, 2]], start = 0, target = 2
    // 输出：true
    //示例2:

    // 输入：n = 5, graph = [[0, 1], [0, 2], [0, 4], [0, 4], [0, 1], [1, 3], [1, 4], [1, 3], [2, 3], [3, 4]], start = 0, target = 4
    // 输出 true
    //提示：

    //节点数量n在[0, 1e5] 范围内。
    //节点编号大于等于 0 小于 n。
    //图中可能存在自环和平行边。
    public class Solution31
    {
        public bool FindWhetherExistsPath(int n, int[][] graph, int start, int target)
        {
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                list.Add(new List<int>());
            }

            for (int i = 0; i < graph.Length; i++)
            {
                list[graph[i][0]].Add(graph[i][1]);
            }
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[n];
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int cur = queue.Dequeue();
                for (int j = 0; j < list[cur].Count; j++)
                {
                    int node = list[cur][j];
                    if (!visited[node]) 
                    {
                        visited[node] = true;
                        if (node == target)
                            return true;

                        queue.Enqueue(node);                   
                    }
                }
            }

            return false;
        }
    }
}
