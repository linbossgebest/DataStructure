using System;

namespace Manacher
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123sadasfs13sfzsfasdafdferga";
            int max=ManacherHelper.MaxPalindromeLength(s);
            Console.WriteLine(max);
        }
    }
}
