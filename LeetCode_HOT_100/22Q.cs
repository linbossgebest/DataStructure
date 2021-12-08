﻿using System;
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
    }
}
