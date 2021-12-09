using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 02.01. 移除重复节点
    //编写代码，移除未排序链表中的重复节点。保留最开始出现的节点。

    //示例1:

    // 输入：[1, 2, 3, 3, 2, 1]
    //    输出：[1, 2, 3]
    //    示例2:

    // 输入：[1, 1, 1, 1, 2]
    //    输出：[1, 2]
    //    提示：

    //链表长度在[0, 20000] 范围内。
    //链表元素在[0, 20000] 范围内。
    //进阶：

    //如果不得使用临时缓冲区，该怎么解决？
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    public class Solution17
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

        public ListNode RemoveDuplicateNodes1(ListNode head)
        {
            if (head == null)
                return null;

            HashSet<int> hs = new();
            hs.Add(head.val);
            ListNode pre = head;
            while (pre.next != null)
            {
                ListNode cur = pre.next;
                if (hs.Add(cur.val))
                    pre = pre.next;
                else
                    pre.next = pre.next.next;
            }
            pre.next = null;//可能末尾是重复节点，则需要吧pre的最后节点指向null
            return head;
        }

        public ListNode RemoveDuplicateNodes2(ListNode head)
        {
            ListNode pre1 = head;
            while (pre1 != null)
            {
                ListNode pre2 = pre1;
                while (pre2.next != null)//移除pre2中所有和pre1值相同的node
                {
                    if (pre2.next.val == pre1.val)
                        pre2.next = pre2.next.next;
                    else
                        pre2 = pre2.next;

                }
                pre1 = pre1.next;
            }
            return head;
        }
    }
}
