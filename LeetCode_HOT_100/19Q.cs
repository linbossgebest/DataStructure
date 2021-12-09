﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //面试题 02.03. 删除中间节点
    //若链表中的某个节点，既不是链表头节点，也不是链表尾节点，则称其为该链表的「中间节点」。

    //假定已知链表的某一个中间节点，请实现一种算法，将该节点从链表中删除。

    //例如，传入节点 c（位于单向链表 a->b->c->d->e->f 中），将其删除后，剩余链表为 a->b->d->e->f



    //示例：

    //输入：节点 5 （位于单向链表 4->5->1->9 中）
    //输出：不返回任何数据，从链表中删除传入的节点 5，使链表变为 4->1->9
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    public class Solution19
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

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;//值替换为下一个node的值
            node.next = node.next.next;//next指针指向下下个node

            //传入节点 c（位于单向链表 a->b->c->d->e->f 中）
            //                         a->b->d->e->f

        }
    }
}
