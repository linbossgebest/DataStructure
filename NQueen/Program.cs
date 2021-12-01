using System;
using System.Diagnostics;

namespace NQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            int n1 = Code_NQueenWithBinary.Num(14);
            s1.Stop();
            Console.WriteLine(n1);
            Console.WriteLine(s1.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
