using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class LinkedlistStack
    {
        public Node top;
        CustomLinkedList list = new CustomLinkedList();
        public void Push(int newData)
        {
            ///creating a link between newnode and where top is pointing
            ///then pointing top toeard the new node
            ///new node is inserted on the top
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;//newnode will hold the address of 
            }
            this.top = newNode;//top will point to new element
            Console.WriteLine("New node{0} is added", newNode.data);

        }
        //Displaying the value in the stack
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("no Values to display , empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the stack:" + temp.data);
                temp = temp.next;
            }
        }
        public void PushByLinkedList(int newData)
        {
            list.AddAtFirst(newData); 
        }
        public void DisplayByLinkedList()
        {
            list.Display();
        }
    }
}