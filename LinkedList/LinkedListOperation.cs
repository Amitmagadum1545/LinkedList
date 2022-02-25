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
            }
        }

        public void Display()
        {
            Console.WriteLine("Displaying Nodes:");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
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
    }
}