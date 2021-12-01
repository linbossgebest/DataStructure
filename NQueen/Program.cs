using System;
using System.Diagnostics;

namespace NQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            ///N皇后问题是指在N*N的棋盘上要摆N个皇后，要求任何两个皇后不同行、不同列，
            ///也不在同一条斜线上。
            ///给定一一个整数n，返回n皇后的摆法有多少种。
            ///n = 1，返回1。
            ///n = 2或3，2皇后和3皇后问题无论怎么摆都不行，返回0。
            ///n = 8，返回92。

            Stopwatch s1 = new Stopwatch();
            s1.Start();
            int n1 = Code_NQueenWithArray.Num(14);
            s1.Stop();
            Console.WriteLine(n1);
            Console.WriteLine(s1.ElapsedMilliseconds);

            Stopwatch s2 = new Stopwatch();
            s2.Start();
            int n2 = Code_NQueenWithBinary.Num(14);
            s2.Stop();
            Console.WriteLine(n2);
            Console.WriteLine(s2.ElapsedMilliseconds);


            Console.ReadKey();
        }
    }
}
