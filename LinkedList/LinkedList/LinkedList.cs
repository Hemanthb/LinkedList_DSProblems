using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        Node head;
        //To add or append new node to a list
        public void addNode(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("Data {0} is added to the list", data);

        }

        public void Displaylist()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
            }
            while(temp != null)
            {
                Console.Write(temp.data+" -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        //To reverse a given linked list
        public void ReverseList()
        {
            Node prev = null,current = head,next = null;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                
            }
            head = prev;
            
        }
        //To Insert a node at a given position
        public void InsertNewNode(int position,int newNodeData)
        {
            Node temp = null, next = null,prevNode = null;
            if (position == 0)
            {
                Node newNode = new Node(newNodeData);
                temp = this.head;
                newNode.next = this.head;
                this.head = newNode;

            }
            else if (position > 0)
            {
                prevNode = this.head;
                while (position != 0)
                {
                    if (position == 1)
                    {
                        Node newNode = new Node(newNodeData);
                        newNode.next = prevNode.next;
                        prevNode.next = newNode;
                    }
                    prevNode = prevNode.next;
                    position--;
                }
                if(position != 1)
                {
                    Console.WriteLine("Invalid Postion");
                }
            }
            else
            {
                Console.WriteLine("Invalid Postion");
            }
        }
        //To Pop First Node of the list
        public void Pop()
        {
            this.head = this.head.next;
            Console.WriteLine("first node deleted");
        }
        //To delete last node of the list
        public void PopLast()
        {

            Node current=this.head,prevNode = null;
            while(current.next != null)
            {
                prevNode = (Node)current;
                current = current.next;
            }
            prevNode.next = null;
            Console.WriteLine("Last Node deleted");
        }
        public int Search(int findData)
        {
            int position = 0;
            while(this.head != null)
            {
                position++;
                if(this.head.data == findData)
                {
                    return position;
                    break;
                }
                this.head = this.head.next;
            }
            return position;
        }
        
    }
}
