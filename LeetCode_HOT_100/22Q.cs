using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 02.06. 回文链表
    //编写一个函数，检查输入的链表是否是回文的。



    //示例 1：

    //输入： 1->2
    //输出： false 
    //示例 2：

    //输入： 1->2->2->1
    //输出： true 


    //进阶：
    //你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
    public class Solution22
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
        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
                return true;

            ListNode firstHalfEnd = EndOfFisrtNode(head);
            ListNode secondHalfStart = ReverseList(firstHalfEnd.next);

            ListNode p1 = head;
            ListNode p2 = secondHalfStart;
            bool result = true;
            while (result && p2 != null)
            {
                if (p1.val != p2.val)
                    result = false;

                p1 = p1.next;
                p2 = p2.next;
            }

            //还原链表
            firstHalfEnd.next = ReverseList(secondHalfStart);
            return result;
        }

        private ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                var temp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = temp;
            }
            return pre;
        }

        private ListNode EndOfFisrtNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }
    }
}
