using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 03.05. 栈排序
    //栈排序。 编写程序，对栈进行排序使最小元素位于栈顶。最多只能使用一个其他的临时栈存放数据，但不得将元素复制到别的数据结构（如数组）中。该栈支持如下操作：push、pop、peek 和 isEmpty。当栈为空时，peek 返回 -1。

    //示例1:

    // 输入：
    //["SortedStack", "push", "push", "peek", "pop", "peek"]
    //    [[], [1], [2], [], [], []]
    // 输出：
    //[null,null,null,1,null,2]
    //    示例2:

    // 输入： 
    //["SortedStack", "pop", "pop", "push", "pop", "isEmpty"]
    //    [[], [], [], [1], [], []]
    // 输出：
    //[null,null,null,null,null,true]
    //    说明:

    //栈中的元素数目在[0, 5000] 范围内。
    public class SortedStack
    {
        Stack<int> stack1;
        Stack<int> stack2;
        public SortedStack()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }

        public void Push(int val)
        {
            if (stack1.Count == 0)
                stack1.Push(val);
            else
            {
                while (stack1.Count != 0 && val > stack1.Peek())
                    stack2.Push(stack1.Pop());

                stack1.Push(val);
                while (stack2.Count() != 0)
                    stack1.Push(stack2.Pop());
            }
        }

        public void Pop()
        {
            if (stack1.Count == 0)
                return;
            stack1.Pop();
        }

        public int Peek()
        {
            if (stack1.Count == 0)
                return -1;
            else
                return stack1.Peek();
        }

        public bool IsEmpty()
        {
            return stack1.Count == 0;
        }
    }
}
