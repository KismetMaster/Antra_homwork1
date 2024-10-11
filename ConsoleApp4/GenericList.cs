using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public static class MyList<T>
    {
        // 使用一个静态的LinkedList来存储元素
        static LinkedList<T> _items = new LinkedList<T>();

        // 添加元素
        public static void Add(T element)
        {
            _items.AddLast(element);
        }

        // 移除指定索引的元素
        public static T Remove(int index)
        {
            if (index < 0 || index >= _items.Count)
            {
                throw new ArgumentOutOfRangeException("Index is out of range.");
            }

            // 遍历LinkedList到达指定索引
            var currentNode = _items.First;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            // 移除并返回节点的值
            if (currentNode != null)
            {
                _items.Remove(currentNode);
                return currentNode.Value;
            }
            throw new InvalidOperationException("Cannot remove item.");
        }

        // 检查是否包含指定元素
        public static bool Contains(T element)
        {
            return _items.Contains(element);
        }

        // 计数方法，返回当前元素的数量
        public static int Count()
        {
            return _items.Count;
        }

        public static void Clear() {
            while (_items.Count > 0) {
                _items.RemoveLast();
            }
        }

        public static void InsertAt(T element, int index) { 
        
        }
    }
}
