using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 02.05. 链表求和
    //给定两个用链表表示的整数，每个节点包含一个数位。

    //这些数位是反向存放的，也就是个位排在链表首部。

    //编写函数对这两个整数求和，并用链表形式返回结果。



    //示例：

    //输入：(7 -> 1 -> 6) + (5 -> 9 -> 2)，即617 + 295
    //输出：2 -> 1 -> 9，即912
    //进阶：思考一下，假设这些数位是正向存放的，又该如何解决呢?

    //示例：

    //输入：(6 -> 1 -> 7) + (2 -> 9 -> 5)，即617 + 295
    //输出：9 -> 1 -> 2，即912
    public class Solution21
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int cal = 0;//进位信息
            ListNode pre = new(0);
            ListNode prelHead = pre;
            while (l1 != null || l2 != null )
            {
                int sum = cal;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                cal = sum / 10;//>10的数字需要进位 cal代表进位信息
                int curVal = sum % 10;//代表进位后
                ListNode curNode = new(curVal);
                pre.next = curNode;
                pre = pre.next;     
            }
            if (cal > 0)
                pre.next = new ListNode(cal);

            return prelHead.next;
        }
    }
}
