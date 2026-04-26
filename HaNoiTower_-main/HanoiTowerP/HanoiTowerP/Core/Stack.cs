using System;
using System.Collections.Generic;
using System.Text;

namespace HanoiTowerP.Core
{
    public class Stack<T>
    {
        private SinglyLinkedList<T> list;

        public Stack()
        {
            this.list = new SinglyLinkedList<T>();
        }

        public void Push(T item)
        {
            this.list.AddFirst(item);
        }

        public T Pop() 
        { 
            return this.list.RemoveFirst();
        }

        public T Peek()
        {
            return this.list.PeekFirst();
        }

        public bool IsEmpty()
        {
            return this.list.IsEmpty();
        }

        public int Count()
        {
            return this.list.Count();
        }

        public Node<T> GetHead()
        {
            return this.list.GetHead();
        }

    }
}
