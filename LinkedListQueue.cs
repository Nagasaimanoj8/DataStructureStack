using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class LinkedListQueue
    {
        public Node head;
        public void Enqueue(int item)
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next!= null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("{0} is inserted into Queue",new_node.data);
        }
        public void Display()
        {
            Node temp=this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(""+temp.data);
                    temp=temp.next;
                }
            }
        }
    }
}
