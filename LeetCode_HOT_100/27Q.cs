using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 03.03. 堆盘子
    //堆盘子。设想有一堆盘子，堆太高可能会倒下来。因此，在现实生活中，盘子堆到一定高度时，我们就会另外堆一堆盘子。请实现数据结构SetOfStacks，模拟这种行为。SetOfStacks应该由多个栈组成，并且在前一个栈填满时新建一个栈。此外，SetOfStacks.push() 和SetOfStacks.pop()应该与普通栈的操作方法相同（也就是说，pop()返回的值，应该跟只有一个栈时的情况一样）。 进阶：实现一个popAt(int index)方法，根据指定的子栈，执行pop操作。

    //当某个栈为空时，应当删除该栈。当栈中没有元素或不存在该栈时，pop，popAt 应返回 -1.

    //示例1:

    // 输入：
    //["StackOfPlates", "push", "push", "popAt", "pop", "pop"]
    //    [[1], [1], [2], [1], [], []]
    // 输出：
    //[null, null, null, 2, 1, -1]
    //    示例2:

    // 输入：
    //["StackOfPlates", "push", "push", "push", "popAt", "popAt", "popAt"]
    //    [[2], [1], [2], [3], [0], [0], [0]]
    // 输出：
    //[null, null, null, null, 2, 1, 3]
    public class StackOfPlates
    {
        List<Stack<int>> stacks;
        int cap;
        public StackOfPlates(int cap)
        {
            stacks = new List<Stack<int>>();
            this.cap = cap;
        }

        public void Push(int val)
        {
            if (cap == 0)
                return;

            if (stacks.Count == 0 || IsFull(stacks[stacks.Count - 1]))
                stacks.Add(new Stack<int>());

            stacks[stacks.Count - 1].Push(val);
        }

        public int Pop()
        {
            if (cap == 0 || stacks.Count == 0)
                return -1;

            var stack = stacks[stacks.Count - 1];
            int popVal = stack.Pop();
            if (stack.Count == 0)
                stacks.Remove(stack);

            return popVal;
        }

        public int PopAt(int index)
        {
            if (cap == 0)
                return -1;
            if (index == (stacks.Count - 1))
                return Pop();
            else if (index > (stacks.Count - 1))
                return -1;
            var stack = stacks[index];
            int popVal = stack.Pop();
            if (stack.Count == 0)
                stacks.Remove(stack);

            return popVal;
        }

        private bool IsFull(Stack<int> stack)
        {
            return stack.Count() == cap;
        }
    }

}
