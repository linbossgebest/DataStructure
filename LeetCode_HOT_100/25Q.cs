using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_HOT_100
{
    //    面试题 03.01. 三合一
    //三合一。描述如何只用一个数组来实现三个栈。

    //你应该实现push(stackNum, value)、pop(stackNum)、isEmpty(stackNum)、peek(stackNum)方法。stackNum表示栈下标，value表示压入的值。

    //构造函数会传入一个stackSize参数，代表每个栈的大小。

    //示例1:

    // 输入：
    //["TripleInOne", "push", "push", "pop", "pop", "pop", "isEmpty"]
    //    [[1], [0, 1], [0, 2], [0], [0], [0], [0]]
    // 输出：
    //[null, null, null, 1, -1, -1, true]
    //    说明：当栈为空时`pop, peek`返回-1，当栈满时`push`不压入元素。
    //示例2:

    // 输入：
    //["TripleInOne", "push", "push", "push", "pop", "pop", "pop", "peek"]
    //    [[2], [0, 1], [0, 2], [0, 3], [0], [0], [0], [0]]
    // 输出：
    //[null, null, null, null, 2, 1, -1, -1]


    //    提示：

    //0 <= stackNum <= 2
    public class TripleInOne
    {
        int[] arr;
        int stackSize;
        int[] indexs;
        public TripleInOne(int stackSize)
        {
            arr = new int[stackSize * 3];
            this.stackSize = stackSize;
            indexs = new int[] { 0, 1, 2 };
        }

        public void Push(int stackNum, int value)
        {
            if (indexs[stackNum] >= stackSize * 3)
                return;

            arr[indexs[stackNum]] = value;
            indexs[stackNum] += 3;
        }

        public int Pop(int stackNum)
        {
            if (IsEmpty(stackNum))
                return -1;

            indexs[stackNum] -= 3;
            return arr[indexs[stackNum]];
        }

        public int Peek(int stackNum)
        {
            if (IsEmpty(stackNum))
                return -1;
            return arr[indexs[stackNum] - 3];
        }

        public bool IsEmpty(int stackNum)
        {
            return indexs[stackNum] < 3;
        }
    }
}
