using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomLinkedList
    {
        public Node head;

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine("{0} is inserted into LinkedList", newNode.data);
        }
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("{0} is inserted into LinkedList", newNode.data);
        }
        public void Append(int data)
        {
            AddLast(data);              //Append is same as AddLast
        }

        public void Insert(int index, int data)
        {
            Node newNode = new Node(data);
            if (index < 0)
            {
                Console.WriteLine("Invaid index position");
            }
            else if (index == 0)
            {
                AddFirst(data);
            }
            else
            {
                Node temp = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
                Console.WriteLine("\nInserted {0} at index {1}", newNode.data, index);
            }
        }

        public void DeleteFirst()
        {
            if (head != null)
            {
                head = head.next;
                Console.WriteLine("\nFirst element deleted");
            }
        }

        public void DeleteLast()
        {
            if (head != null && head.next != null)
            {
                Node newNode = head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
                Console.WriteLine("\nLast element deleted");
            }
            else
                Console.WriteLine("\nLinkedlist is either empty or contains only one element");
        }

        public void DeleteParticularElement(int data)
        {
            Node temp = head;
            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("\n{0} is Deleted", data);
                }
                temp = temp.next;
            }
        }

        public void SearchVaue(int data)
        {
            Node temp = head;
            int search = 0;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    search = 1;
                }
                temp = temp.next;
            }
            if (search == 1)
                Console.WriteLine("\n{0} is present in the linkedlist", data);
            else
                Console.WriteLine("\n{0} is not present in the linkedlist", data);
        }

        public int FindPosition(int value)
        {
            Node temp = head;
            int index = 0;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return index;
                }
                temp = temp.next;
                index++;
            }
            return -1;
        }

        public void InsertAfter(int value, int data)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    int position = FindPosition(value);
                    Insert(position + 1, data);
                }
                temp = temp.next;
            }
        }

        public void Display()
        {
            Console.WriteLine("\nDisplaying Nodes:");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        public void Size()
        {
            int size = 0;
            Node temp = this.head;
            while (temp != null)
            {
                temp = temp.next;
                size++;
            }
            Console.WriteLine("\nSize of the LinkedList is {0}", size);
        }
    }
}