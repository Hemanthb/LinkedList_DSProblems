using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        Node head;
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
        
    }
}
