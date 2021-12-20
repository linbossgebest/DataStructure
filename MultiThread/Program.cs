using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThread
{
    class Program
    {
        static AutoResetEvent AautoResetEvent = new AutoResetEvent(false);
        static AutoResetEvent BautoResetEvent = new AutoResetEvent(false);
        static AutoResetEvent CautoResetEvent = new AutoResetEvent(false);

        //static EventWaitHandle AautoResetEvent = new ManualResetEvent(false);
        //static EventWaitHandle BautoResetEvent = new ManualResetEvent(false);
        //static EventWaitHandle CautoResetEvent = new ManualResetEvent(false);

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

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        LoopPrint l = new LoopPrint();
    //        new Thread(() =>
    //        {
    //            for (int i = 1; i <= 20; i++)
    //            {
    //                l.loopA(i);
    //            }
    //        }).Start();
    //        new Thread(() =>
    //        {
    //            for (int i = 1; i <= 20; i++)
    //            {
    //                l.loopB(i);
    //            }
    //        }).Start();
    //        new Thread(() =>
    //        {
    //            for (int i = 1; i <= 20; i++)
    //            {
    //                l.loopC(i);
    //            }
    //        }).Start();
    //        Console.ReadLine();
    //    }
    //}
    //class LoopPrint
    //{
    //    private static int name = 1;
    //    static object obj = new object();
    //    public void loopA(int total)
    //    {
    //        lock (obj)
    //        {
    //            if (name != 1)
    //            {
    //                Monitor.Wait(obj);
    //            }
    //            for (int i = 0; i <= 5; i++)
    //            {
    //                Console.WriteLine("线程id:" + Thread.CurrentThread.ManagedThreadId + "\t A \t " + i + "\t" + total);
    //            }
    //            Console.WriteLine("--------loopA结束-----------");
    //            name = 2;
    //            Monitor.Pulse(obj);
    //        }
    //    }
    //    public void loopB(int total)
    //    {
    //        lock (obj)
    //        {
    //            if (name != 2)
    //            {
    //                Monitor.Wait(obj);
    //            }
    //            for (int i = 0; i <= 10; i++)
    //            {

    //                Console.WriteLine("线程id:" + Thread.CurrentThread.ManagedThreadId + "\t B \t " + i + "\t" + total);
    //            }
    //            name = 3;
    //            Console.WriteLine("--------loopB结束-----------");
    //            Monitor.Pulse(obj);
    //        }
    //    }
    //    public void loopC(int total)
    //    {
    //        lock (obj)
    //        {
    //            if (name != 3)
    //            {
    //                Monitor.Wait(obj);

    //            }
    //            for (int i = 0; i <= 15; i++)
    //            {

    //                Console.WriteLine("线程id:" + Thread.CurrentThread.ManagedThreadId + "\t C \t " + i + "\t" + total);
    //            }
    //            name = 1;
    //            Console.WriteLine("--------loopC结束-----------");
    //            Monitor.Pulse(obj);
    //        }
    //    }

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //演示前台、后台线程
    //        BackGroundTest background = new BackGroundTest(10);
    //        //创建前台线程
    //        Thread fThread = new Thread(new ThreadStart(background.RunLoop));
    //        //给线程命名
    //        fThread.Name = "前台线程";


    //        BackGroundTest background1 = new BackGroundTest(20);
    //        //创建后台线程
    //        Thread bThread = new Thread(new ThreadStart(background1.RunLoop));
    //        bThread.Name = "后台线程";
    //        //设置为后台线程
    //        bThread.IsBackground = true;

    //        //启动线程
    //        fThread.Start();
    //        bThread.Start();
    //    }
    //}

    //class BackGroundTest
    //{
    //    private int Count;
    //    public BackGroundTest(int count)
    //    {
    //        this.Count = count;
    //    }
    //    public void RunLoop()
    //    {
    //        //获取当前线程的名称
    //        string threadName = Thread.CurrentThread.Name;
    //        for (int i = 0; i < Count; i++)
    //        {
    //            Console.WriteLine("{0}计数：{1}", threadName, i.ToString());
    //            //线程休眠1000毫秒
    //            Thread.Sleep(1000);
    //        }
    //        Console.WriteLine("{0}完成计数", threadName);

    //    }
    //}


}
