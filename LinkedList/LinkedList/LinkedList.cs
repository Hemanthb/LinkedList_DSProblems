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
                temp = node;
            }
            Console.WriteLine("Data {0} is added to the list", data);

        }
        
    }
}
