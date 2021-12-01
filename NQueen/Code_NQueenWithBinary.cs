using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen
{
    public static class Code_NQueenWithBinary
    {
        public static int Num(int n)
        {
            if (n < 1 || n > 32)
                return 0;

            int limit = n == 32 ? -1 : (1 << n) - 1;//n位皇后问题 就对应 000001..n..1 n个1
            return Process(limit,0,0,0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="limit">位限制</param>
        /// <param name="colLim">列限制</param>
        /// <param name="leftDiaLim">左斜线限制</param>
        /// <param name="rightDiaLim">右斜线限制</param>
        /// <returns></returns>
        private static int Process(int limit, int colLim, int leftDiaLim, int rightDiaLim)
        { 
            if (colLim == limit)
                return 1;

            int pos;
            int mostRightOne;//最右测的1
            //例：
            //第0行                                            00001000
            //第1行的限制：
            //列限制                                           00001000
            //左斜线限制                                       00010000
            //右斜线限制                                       00000100
            //colLim | leftDiaLim | rightDiaLim                00011100
            //~(colLim | leftDiaLim | rightDiaLim)             11100011
            //limit & (~(colLim | leftDiaLim | rightDiaLim))   00011100
            pos = limit & (~(colLim | leftDiaLim | rightDiaLim));//位上剩余1表示 可作为放置皇后的位置
            int res = 0;
            while (pos != 0)
            {
                mostRightOne = pos & (~pos + 1);//提取pos最右侧的1  => 00011100 00000100
                pos = pos - mostRightOne;// 00011100-00000100 = 00011000
                // colLim | mostRightOne  => 新的列限制
                //(leftDiaLim | mostRightOne) << 1    =>  新的左斜线限制   
                //(rightDiaLim | mostRightOne) >> 1   =>  新的右斜线限制
                res += Process(limit, colLim | mostRightOne, (leftDiaLim | mostRightOne) << 1, (rightDiaLim | mostRightOne) >> 1);
            }

            return res;
        }
    }
}
