using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolentRecursion
{
    /// <summary>
    /// 机器人移动问题
    /// </summary>
    public class RobotWalk
    {
        //机器人移动问题 ：
        //有N 1-N 这么多位置 到1的位置时，机器人只能往右走；到N的位置时，机器人只能往左走
        //S位置 机器人初始位置
        //E位置 机器人目标位置
        //k步数 机器人必须走k步到达E位置
        //Q：有多少种走法?

        public static int RobotWays1(int N, int E, int S, int k)
        {
            return f1(N, E, k, S);
        }

        /// <summary>
        /// 暴力递归
        /// </summary>
        /// <param name="N">1-N 这么多位置 固定参数</param>
        /// <param name="E">目标位置 固定参数</param>
        /// <param name="rest">剩余步数</param>
        /// <param name="cur">当前位置</param>
        /// <returns></returns>
        public static int f1(int N, int E, int rest, int cur)
        {
            if (rest == 0)
                return cur == E ? 1 : 0;

            if (cur == 1)
                return f1(N, E, rest - 1, 2);

            if (cur == N)
                return f1(N, E, rest - 1, N - 1);

            return f1(N, E, rest - 1, cur - 1) + f1(N, E, rest - 1, cur + 1);
        }

        public static int RobotWays2(int N, int E, int S, int k)
        {
            int[,] db = new int[k + 1, N + 1];
            for (int i = 0; i <= k; i++)
                for (int j = 0; j <= N; j++)
                    db[i, j] = -1;
            return f2(N, E, k, S, db);
        }

        /// <summary>
        /// 记忆搜索（添加缓存）
        /// </summary>
        /// <param name="N"></param>
        /// <param name="E"></param>
        /// <param name="rest"></param>
        /// <param name="cur"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public static int f2(int N, int E, int rest, int cur, int[,] db)
        {
            if (db[rest, cur] != -1)
                return db[rest, cur];

            if (rest == 0)
            {
                db[rest, cur] = cur == E ? 1 : 0;
                return db[rest, cur];
            }

            if (cur == 1)
            {
                db[rest, cur] = f2(N, E, rest - 1, 2, db);
                return db[rest, cur];
            }
            else if (cur == N)
            {
                db[rest, cur] = f2(N, E, rest - 1, N - 1, db);
                return db[rest, cur];
            }
            else
            {
                db[rest, cur] = f2(N, E, rest - 1, cur - 1, db) + f2(N, E, rest - 1, cur + 1, db);
                return db[rest, cur];
            }
        }


        public static int RobotWays3(int N, int E, int S, int k)
        {
            int[,] db = new int[k + 1, N + 1];
            for (int i = 0; i <= k; i++)
                for (int j = 0; j <= N; j++)
                    db[i, j] = -1;
            return f3(N, E, k, S, db);
        }

        /// <summary>
        /// 严格表结构（动态规划）
        /// </summary>
        /// <param name="N">1-N 这么多位置 固定参数</param>
        /// <param name="E">目标位置 固定参数</param>
        /// <param name="rest">剩余步数</param>
        /// <param name="cur">当前位置</param>
        /// <param name="db">缓存</param>
        /// <returns></returns>
        public static int f3(int N, int E, int rest, int cur, int[,] db)
        {
            if (db[rest, cur] != -1)
                return db[rest, cur];

            if (rest == 0)
                db[rest, cur] = cur == E ? 1 : 0;

            if (cur == 1)
                db[rest, cur] = f2(N, E, rest - 1, 2, db);

            else if (cur == N)
                db[rest, cur] = f2(N, E, rest - 1, N - 1, db);
            else
                db[rest, cur] = f2(N, E, rest - 1, cur - 1, db) + f2(N, E, rest - 1, cur + 1, db);

            return db[rest, cur];
        }


        public static void Test()
        {
            int N = 31;
            int E = 8;
            int S = 5;
            int K = 13;
           if( RobotWays1(N, E, S, K)!= RobotWays2(N, E, S, K)|| RobotWays1(N, E, S, K)!= RobotWays3(N, E, S, K))
                Console.WriteLine("结果不一致");

            Console.WriteLine($"结果一致:{RobotWays1(N, E, S, K)}");
        }
    }
}
