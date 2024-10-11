using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MyStack<T>
    {
        private List<T> stackList = new List<T>();  // 内部使用 List 来存储元素

        // 返回当前栈中的元素数量
        public int Count()
        {
            return stackList.Count;
        }

        // 从栈顶弹出元素并返回，如果栈为空则抛出异常
        public T Pop()
        {
            if (stackList.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T topItem = stackList[stackList.Count - 1];
            stackList.RemoveAt(stackList.Count - 1);
            return topItem;
        }

        // 将元素压入栈顶
        public void Push(T item)
        {
            stackList.Add(item);
        }
    }
}
