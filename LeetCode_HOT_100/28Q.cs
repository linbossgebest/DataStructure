using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 03.04. 化栈为队
    //实现一个MyQueue类，该类用两个栈来实现一个队列。


    //示例：

    //MyQueue queue = new MyQueue();

    //    queue.push(1);
    //queue.push(2);
    //queue.peek();  // 返回 1
    //queue.pop();   // 返回 1
    //queue.empty(); // 返回 false

    //说明：

    //你只能使用标准的栈操作 -- 也就是只有 push to top, peek/pop from top, size 和 is empty 操作是合法的。
    //你所使用的语言也许不支持栈。你可以使用 list 或者 deque（双端队列）来模拟一个栈，只要是标准的栈操作即可。
    //假设所有操作都是有效的 （例如，一个空的队列不会调用 pop 或者 peek 操作）。
    public class MyQueue
    {
        Stack<int> stack1;
        Stack<int> stack2;
        /** Initialize your data structure here. */
        public MyQueue()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        /** Push element x to the back of queue. */
        public void Push(int x)
        {
            stack1.Push(x);
        }

        /** Removes the element from in front of queue and returns that element. */
        public int Pop()
        {
            InQueue();
            return stack2.Pop();
        }

        /** Get the front element. */
        public int Peek()
        {
            InQueue();
            return stack2.Peek();
        }

        /** Returns whether the queue is empty. */
        public bool Empty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }

        private void InQueue()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
                
            }
        }
    }
}
