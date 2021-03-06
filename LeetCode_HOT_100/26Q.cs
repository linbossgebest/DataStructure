using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 03.02. 栈的最小值
    //请设计一个栈，除了常规栈支持的pop与push函数以外，还支持min函数，该函数返回栈元素中的最小值。执行push、pop和min操作的时间复杂度必须为O(1)。


    //示例：

    //MinStack minStack = new MinStack();
    //minStack.push(-2);
    //minStack.push(0);
    //minStack.push(-3);
    //minStack.getMin();   --> 返回 -3.
    //minStack.pop();
    //minStack.top();      --> 返回 0.
    //minStack.getMin();   --> 返回 -2.
    public class MinStack26
    {
        Stack<int> stackData;
        Stack<int> stackMin;
        /** initialize your data structure here. */
        public MinStack26()
        {
            stackData = new Stack<int>();
            stackMin = new Stack<int>();
        }

        public void Push(int x)
        {
            stackData.Push(x);
            if (stackMin.Count == 0)
                stackMin.Push(x);
            else
            {
                if (x <= stackMin.Peek())
                    stackMin.Push(x);
            }    
        }

        public void Pop()
        {
            int val = stackData.Pop();
            if (val == stackMin.Peek())
                stackMin.Pop();
        }

        public int Top()
        {
            return stackData.Peek();
        }

        public int GetMin()
        {
            return stackMin.Peek();
        }
    }
}
