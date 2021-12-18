using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //求链表中倒数第k个节点
    public  class Solution47
    {
        public ListNode KthNodeFromEnd(ListNode head, int kthNode)
        {
            if (head == null || kthNode < 0)
                return null;

            var fast = head;
            var slow = head;

            for (int i = 0; i < kthNode - 1; i++)
                fast = fast.next;

            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }

            return slow;
        }
    }
}
