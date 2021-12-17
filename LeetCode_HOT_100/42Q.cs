using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    83. 删除排序链表中的重复元素
    //存在一个按升序排列的链表，给你这个链表的头节点 head ，请你删除所有重复的元素，使每个元素 只出现一次 。

    //返回同样按升序排列的结果链表。



    //示例 1：


    //输入：head = [1,1,2]
    //    输出：[1,2]
    //    示例 2：


    //输入：head = [1,1,2,3,3]
    //    输出：[1,2,3]


    //    提示：

    //链表中节点数目在范围[0, 300] 内
    //-100 <= Node.val <= 100
    //题目数据保证链表已经按升序排列
    public class Solution42
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
        public ListNode DeleteDuplicates1(ListNode head)
        {
            if (head == null)
                return null;

            ListNode cur = head;
            while (cur.next != null)
            {
                if (cur.val == cur.next.val)
                    cur.next = cur.next.next;
                else
                    cur = cur.next;
            }

            return head;
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null||head.next==null)
                return head;

            head.next = DeleteDuplicates(head.next);
            return head.val == head.next.val ? head.next : head;
        }
    }
}
