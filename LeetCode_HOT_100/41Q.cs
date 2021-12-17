using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    21. 合并两个有序链表
    //将两个升序链表合并为一个新的 升序 链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 



    //示例 1：


    //输入：l1 = [1,2,4], l2 = [1,3,4]
    //    输出：[1,1,2,3,4,4]
    //    示例 2：

    //输入：l1 = [], l2 = []
    //    输出：[]
    //    示例 3：

    //输入：l1 = [], l2 = [0]
    //    输出：[0]


    //    提示：

    //两个链表的节点数目范围是[0, 50]
    //-100 <= Node.val <= 100
    //l1 和 l2 均按 非递减顺序 排列
    public class Solution41
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

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;
            ListNode temp = new ListNode(-1);
            var cur = temp;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    cur.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    cur.next = list2;
                    list2 = list2.next;
                }

                cur = cur.next;
            }

            if (list1 != null)
                cur.next = list1;
            if (list2 != null)
                cur.next = list2;

            return temp.next;
        }

        public ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists1(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists1(list1, list2.next);
                return list2;
            }
            

        }
    }
}
