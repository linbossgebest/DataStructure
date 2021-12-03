using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP
{
    public static class KMPHelper
    {
        public static int KMP_IndexOf(string s, string m)
        {
            if (s == null || m == null || m.Length < 1 || s.Length < m.Length)
                return -1;

            char[] str1 = s.ToCharArray();
            char[] str2 = m.ToCharArray();
            int i1 = 0;
            int i2 = 0;
            int[] next = GetNextArray(str2);
            while (i1 < str1.Length && i2 < str2.Length)
            {
                if (str1[i1] == str2[i2])
                {
                    i1++;
                    i2++;
                }
                else if (next[i2] == -1)//i2==0
                {
                    i1++;
                }
                else {
                    i2 = next[i2];
                }
            }

            return i2 == str2.Length ? i1 - i2 : -1;
        }

        private static int[] GetNextArray(char[] ms)
        {
            if (ms.Length == 1)
                return new int[] { -1 };
            int[] next = new int[ms.Length];
            next[0] = -1;// 0位置i=0  next[0]=-1
            next[1] = 0;//  1位置i=1  next[1]=0
            int i = 2;
            int cn = 0;
            while (i < next.Length)
            {
                if (ms[i - 1] == ms[cn])
                {
                    next[i] = cn + 1;
                    i++;
                    cn++;
                }
                else if (cn > 0)
                {
                    cn = next[cn];
                }
                else
                {
                    next[i] = 0;
                    i++;
                }
            }
            return next;
        }
    }
}
