using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    class Program
    {
        static AutoResetEvent AautoResetEvent = new AutoResetEvent(false);
        static AutoResetEvent BautoResetEvent = new AutoResetEvent(false);
        static AutoResetEvent CautoResetEvent = new AutoResetEvent(false);
        static void ShowA()
        {
            for (int i = 0; i < 10; i++)
            {
                AautoResetEvent.WaitOne();
                Console.Write("A");
                BautoResetEvent.Set();
            }
        }
        static void ShowB()
        {
            for (int i = 0; i < 10; i++)
            {
                BautoResetEvent.WaitOne();
                Console.Write("B");
                CautoResetEvent.Set();
            }
        }
        static void ShowC()
        {
            for (int i = 0; i < 10; i++)
            {
                CautoResetEvent.WaitOne();
                Console.Write("C");
                AautoResetEvent.Set();
            }
        }
        static void Main(string[] args)
        {
            Task.Run(() => ShowA());
            Task.Run(() => ShowB());
            Task.Run(() => ShowC());
            AautoResetEvent.Set();
            Console.ReadLine();
        }

    }
}
