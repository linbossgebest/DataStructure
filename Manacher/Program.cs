using System;

namespace Manacher
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123sadasfs13sfzsfasdafdferga";
            string s1 = "ababa";
            int max=ManacherHelper.MaxPalindromeLength(s1);
            Console.WriteLine(max);
        }
    }
}
