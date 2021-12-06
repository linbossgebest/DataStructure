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

        //k值实际是j位前的子串的最大重复子串的长度
        //在“aba”中，前缀集就是除掉最后一个字符'a'后的子串集合{a,ab}，同理后缀集为除掉最前一个字符a后的子串集合{a,ba}，那么两者最长的重复子串就是a，k=1；int[] next=[-1,0,1]
        //在“ababa”中，前缀集是{a,ab,aba,abab}，后缀集是{a,ba,aba,baba}，二者最长重复子串是aba，k = 3；int[] next=[-1,0,1,2,3]
        //在“abcabcdabc”中，前缀集是{ a,ab,abc,abca,abcab,abcabc,abcabcd,abcabcda,abcabcdab}，后缀集是{ c,bc,abc,dabc,cdabc,bcdabc,abcdabc,cabcdabc,bcabcdabc}，二者最长重复的子串是“abc”,k = 3； 
        private static int[] GetNextArray(char[] ms)
        {
            if (ms.Length == 1)
                return new int[] { -1 };
            int[] next = new int[ms.Length];
            next[0] = -1;// 0位置i=0  next[0]=-1
            next[1] = 0; // 1位置i=1  next[1]=0
            int i = 2;
            int cn = 0;
            while (i < next.Length)
            {
                if (ms[i - 1] == ms[cn])
                {
                    //next[i] = cn + 1;
                    //i++;
                    //cn++;
                    next[i++] = ++cn;
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
