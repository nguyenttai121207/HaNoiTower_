using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HanoiTowerP.Core
{

    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)  
        {
            this.Data = data;
            this.Next = null;
        }
    }

    public class SinglyLinkedList<T>
    {
        private Node<T> head;
        private int count;

        // Constructor

        public SinglyLinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        // IsEmpty method

        public bool IsEmpty()
        {
            return this.count == 0;
        }

        // Add method

        public Node<T> GetHead()
        {
            return this.head;
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = this.head;
            this.head = newNode;
            this.count++;
        }

        public void AddLast(T data) 
        { 
            Node<T> newNode = new Node<T>(data);
            Node<T> current = this.head;
            if (current == null)
            {
                this.head = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            this.count++;
        }

        public T RemoveFirst()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }
            T value = this.head.Data;
            this.head = this.head.Next;
            this.count--;
            return value;
        }

        public T PeekFirst()
        {
            if (this.IsEmpty())
            {
                return default(T);
            }
            return this.head.Data;
        }


        // Thêm vào SinglyLinkedList<T>
   
        public int Count()=> this.count;

        



    }
}
