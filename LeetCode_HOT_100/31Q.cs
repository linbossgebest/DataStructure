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
        public bool Test()
        {
            int[][] graph = new int[][]
            {
                 new int[]{ 0,1},
                 new int[]{ 0,2},
                 new int[]{ 0,4},
                 new int[]{ 0,4},
                 new int[]{ 0,1},   new int[]{1, 3},   new int[]{1, 4},   new int[]{1, 3},   new int[]{2, 3},   new int[]{3, 4}
            };
            //return FindWhetherExistsPath1(5, graph, 0, 4);
            return FindWhetherExistsPath2(5, graph, 0, 4);
        }

        /// <summary>
        /// BFS
        /// </summary>
        /// <param name="n"></param>
        /// <param name="graph"></param>
        /// <param name="start"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public bool FindWhetherExistsPath1(int n, int[][] graph, int start, int target)
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

        public bool FindWhetherExistsPath2(int n, int[][] graph, int start, int target)
        {
            Dictionary<int, HashSet<int>> dic = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < graph.Length; i++)
            {
                if (!dic.ContainsKey(graph[i][0]))
                {
                    dic.Add(graph[i][0], new HashSet<int>());
                }
                dic[graph[i][0]].Add(graph[i][1]);
            }

            return DFS(start, target, dic, new HashSet<int>());
        }

        private bool DFS(int start, int target, Dictionary<int, HashSet<int>> dic, HashSet<int> visited)
        {
            if (visited.Contains(start) || !dic.ContainsKey(start))
                return false;
            else if (dic[start].Contains(target))
                return true;

            visited.Add(start);
            foreach (var item in dic[start])
            {
                if (DFS(item, target, dic, visited))
                    return true;
            }
            return false;
        }
    }
}
