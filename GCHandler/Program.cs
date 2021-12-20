using System;
using System.IO;
using System.Runtime.InteropServices;

namespace GCHandler
{

    //我们在使用c#托管代码时，内存地址和GC回收那不是我们关心的，CLR已经给我们暗箱操作。
    //但是如果我们在c#中调用了一个非托管代码，比如vc的DLL,而且他有个回调函数，需要引用c#中的某个对象并操作，
    //这时候你就得要小心了。
    //要是非托管代码中用到得托管代码那个对象被GC给回收了，这时候就会报内存错误。
    //所以我们就要把那个对象“钉”住(pin)，让它的内存地址固定，而不被垃圾回收掉，然后最后我们自己管理，自己释放内存,这时候就需要GCHandle,来看个msdn上的例子:
    public delegate bool CallBack(int handle, IntPtr param);
    public class LibWrap
    {
        [DllImport("user32.dll")]
        public static extern bool EnumWindows(CallBack cb, IntPtr param);
    }

    class Program
    {
        static void Main(string[] args)
        {

            TextWriter tw = System.Console.Out;
            GCHandle gch = GCHandle.Alloc(tw);
            CallBack cewp = new CallBack(CaptureEnumWindowsProc);
            LibWrap.EnumWindows(cewp, (IntPtr)gch);
            gch.Free();
            Console.Read();

        }
        private static bool CaptureEnumWindowsProc(int handle, IntPtr param)
        {
            GCHandle gch = (GCHandle)param;
            TextWriter tw = (TextWriter)gch.Target;

            tw.WriteLine(handle);
            return true;
        }

    }
}
