using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    internal class MyStack<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node last;
        private int count;

        public MyStack()
        {
            last = null;
            count = 0;
        }

        public T CurrentElement
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Стек пуст");
                return last.Data;
            }
        }

        public int Count
        {
            get { return count; }
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public void Add(T item)
        {
            Node newNode = new Node(item);
            if (last == null)
            {
                last = newNode;
            }
            else
            {
                Node old = last;
                newNode.Next = old;
                last = newNode;
            }
            count++;
        }

        public T Remove()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            T data = last.Data;
            last = last.Next;
            count--;
            return data;
        }

        public void Clear()
        {
            last = null;
            count = 0;
        }
    }
}
