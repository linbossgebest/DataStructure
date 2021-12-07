using System;
using System.Diagnostics;

namespace KMP
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abcdefghigadasdfafsafas2wegfbhgfababa";
            string s2 = "abcabcdabc";
            Stopwatch stop1 = new Stopwatch();
            stop1.Start();
            int index1 = KMPHelper.KMP_IndexOf(s1, s2);
            stop1.Stop();

            Stopwatch stop2 = new Stopwatch();
            stop2.Start();
            int index2 = s1.IndexOf(s2);
            stop2.Stop();
            Console.WriteLine($"kmpindexOf:{stop1.ElapsedMilliseconds}:{index1}");

            Console.WriteLine($"indexOf:{stop2.ElapsedMilliseconds}:{index2}");

            Console.ReadKey();
        }
    }
}
