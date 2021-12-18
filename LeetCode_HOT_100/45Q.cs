﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{

    //    234. 回文链表
    //给你一个单链表的头节点 head ，请你判断该链表是否为回文链表。如果是，返回 true ；否则，返回 false 。



    //示例 1：


    //输入：head = [1,2,2,1]
    //    输出：true
    //示例 2：


    //输入：head = [1,2]
    //    输出：false


    //提示：

    //链表中节点数目在范围[1, 105] 内
    //0 <= Node.val <= 9


    //进阶：你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
    public class Solution45
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast != null)
            {
                slow = slow.next;
            }
            fast = head;
            slow = Reverse(slow);

            while (slow != null)
            {
                if (slow.val != fast.val)
                    return false;

                slow = slow.next;
                fast = fast.next;
            }

            return true;

        }

        private ListNode Reverse(ListNode head)
        {
            if (head == null)
                return null;

            ListNode pre = null;
            while (head != null)
            {
                ListNode next = head.next;
                head.next = pre;
                pre = head;
                head = next;              
            }

            return pre;
        }

    }
}
