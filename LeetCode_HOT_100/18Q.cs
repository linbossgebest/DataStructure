using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 02.02. 返回倒数第 k 个节点
    //实现一种算法，找出单向链表中倒数第 k 个节点。返回该节点的值。

    //注意：本题相对原题稍作改动

    //示例：

    //输入： 1->2->3->4->5 和 k = 2
    //输出： 4
    //说明：

    //给定的 k 保证是有效的。
    /**
  * Definition for singly-linked list.
  * public class ListNode {
  *     public int val;
  *     public ListNode next;
  *     public ListNode(int x) { val = x; }
  * }
  */
    public class Solution18
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

        public int KthToLast(ListNode head, int k)
        {
            ListNode first = head;
            ListNode second = head;
            while (k > 0)
            {
                first = first.next;
                k--;
            }
            while (first != null)//first先走k步，然后first second一起next 等到first为空，second还有k步没走
            {
                first = first.next;
                second = second.next;
            }
            return second.val;
        }
    }
}
