using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 02.04. 分割链表
    //给你一个链表的头节点 head 和一个特定值 x ，请你对链表进行分隔，使得所有 小于 x 的节点都出现在 大于或等于 x 的节点之前。

    //你不需要 保留 每个分区中各节点的初始相对位置。

    //示例 1：
    //1=>4=>3=>2=>5=>2
    //1=>2=>2=>4=>3=>5

    //输入：head = [1,4,3,2,5,2], x = 3
    //输出：[1,2,2,4,3,5]


    //    示例 2：

    //输入：head = [2,1], x = 2
    //输出：[1,2]

    //    提示：

    //链表中节点的数目在范围[0, 200] 内
    //-100 <= Node.val <= 100
    //-200 <= x <= 200
    public class Solution20
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

        public ListNode Partition(ListNode head, int x)
        {
            ListNode small = new ListNode(0);
            ListNode smallHead = small;
            ListNode large = new ListNode(0);
            ListNode largeHead = large;
            while (head != null)
            {
                if (head.val < x)
                {
                    small.next = head;
                    small = small.next;
                }
                else 
                {
                    large.next = head;
                    large = large.next;
                }

                head = head.next;
            }
            large.next = null;
            small.next = largeHead.next;
            return smallHead.next;
        }
    }
}
