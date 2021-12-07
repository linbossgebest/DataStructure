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

        //k值实际是j位前子串的最大重复子串的长度(j从0开始)
        //在“aba”中，  
        //a  默认k=-1
        //ab 默认k=0
        //aba j=2计算最后一个字符a之前ab的最大重复子串的长度 {a} {b} k=0 
        //int[] next =[-1, 0, 0]
        //在“ababa”中
        //a  默认k=-1
        //ab 默认k=0
        //aba   j=2计算最后一个字符a之前ab的最大重复子串的长度 前缀集{a} 后缀集{b} 没有重复子串 k=0 
        //abab  j=3计算最后一个字符b之前aba的最大重复子串的长度 前缀集{a,ab} 后缀集{a,ba} 二者最长重复子串是a 长度为1 k=1
        //ababa j=4计算最后一个字符a之前abab的最大重复子串的长度 前缀集{a,ab,aba} 后缀集{b,ab,bab} 二者最长重复子串是ab 长度为2 k = 2
        //int[] next=[-1,0,0,1,2]
        //在“abcabcdabc”中，
        //a  默认k=-1
        //ab 默认k=0
        //abc 计算最后一个字符c之前ab的最大重复子串的长度 {a} {b} 没有重复子串 k=0 
        //abca 计算最后一个字符a之前abc的最大重复子串的长度 前缀集{a,ab} 后缀集{c,bc} 没有重复子串 k=0
        //abcab 计算最后一个字符b之前abca的最大重复子串的长度 前缀集{a,ab,abc} 后缀集{a,ca,bca} 二者最长重复子串是a 长度为1 k=1
        //abcabc 计算最后一个字符c之前abcab的最大重复子串的长度 前缀集{a,ab,abc,abca} 后缀集{b,ab,cab bcab} 二者最长重复子串是ab 长度为2 k=2
        //abcabcd 计算最后一个字符d之前abcabc的最大重复子串的长度 前缀集{a,ab,abc,abca,abcab} 后缀集{c,bc,abc,cabc,bcabc} 二者最长重复子串是abc 长度为3 k=3
        //abcabcda 计算最后一个字符a之前abcabcd的最大重复子串的长度 前缀集{a,ab,abc,abca,abcab,abcabc} 后缀集{d,cd,bcd,abcd,cabcd,bcabcd} 没有重复子串 k=0
        //abcabcdab 计算最后一个字符b之前abcabcda的最大重复子串的长度 前缀集{a,ab,abc,abca,abcab,abcabc,abcabcd}
        //                                                            后缀集{a,da,cda,bcda,abcda,cabcda,bcabcda} 二者最长重复子串是a  k=1
        //abcabcdabc 计算最后一个字符c之前abcabcdab的最大重复子串的长度 前缀集{a,ab,abc,abca,abcab,abcabc,abcabcd,abcabcda} 
        //                                                              后缀集{b,ab,dab,cdab,bcdab,abcdab,cabcdab,bcabcdab} 二者最长重复子串是ab 长度为2 k=2
        //int[] next=[-1,0,0,0,1,2,3,0,1,2]
        private static int[] GetNextArray(char[] ms)
        {
            if (ms.Length == 1)
                return new int[] { -1 };
            int[] next = new int[ms.Length];
            next[0] = -1;// 0位置i=0  next[0]=-1
            next[1] = 0; // 1位置i=1  next[1]=0
            int i = 2;
            int cn = 0;//拿哪个位置的字符和i-1位置的字符比较 初始值为0和位置1上的值作比较 
            while (i < next.Length)
            {
                //想知道next[] i位置的值 需要比较ms[] 上i-1位置的值和cn位置的值是否相等
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
                    //next[i] = 0;
                    //i++;
                    next[i++] = 0;
                }
            }
            return next;
        }
    }
}
