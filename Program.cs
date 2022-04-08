using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Please choose program number to execute");
            Console.WriteLine("1:LinkedList\n2:Stack\n3:Queue\n4:Exit\n5:Stack Using LinkedList\n6:Splitting Array into 2Arrays\n7:HashTable\n8:BinarySearchTree");
            int input =Convert.ToInt32(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("Builin");
                    LinkedList<int> list = new LinkedList<int>();
                    list.AddLast(10);
                    list.AddLast(20);
                    list.AddLast(30);
                    break;
                
                case 2:
                    LinkedlistStack stack = new LinkedlistStack();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    // stack.Peek();
                    // stack.Pop();
                    Console.WriteLine( "is stack empty? {0}", stack.isEmpty()); 
                    stack.Display();
                    break;
                case 3:
                    LinkedListQueue queue=new LinkedListQueue();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display(); 
                    break;

                case 5:
                    LinkedlistStack customStack = new LinkedlistStack();
                    customStack.PushByLinkedList(70);
                    customStack.PushByLinkedList(30);
                    customStack.PushByLinkedList(56);
                    customStack.DisplayByLinkedList();
                    break;

                default:
                    break;
            }
            // LinkedList<int> my_line = new LinkedList<int>();
            // my_line.AddLast(10);
            // my_line.AddLast(70);
            //my_line.AddFirst(300);
            //Stack<int> stack = new Stack<int>();
            //stack.Push(20);
            //stack.Push(10);
            //stack.Push(30);
            //stack.Pop();

           // CustomLinkedList linkedList = new CustomLinkedList();
           // linkedList.AddAtLast(56);
            //linkedList.AddAtLast(30);
            //linkedList.AddAtLast(70);
            //linkedList.Display();
            //  linkedList.InsertAtParticularPosition(2, 30);
            // Console.WriteLine("\n{0}is deleted from the Linkedlist",  linkedList.DeleteLastNode());
            // linkedList.Display();
           // Console.WriteLine( "\n{0} is present", linkedList.Search(30));
            Console.ReadLine();
        }
           

        }

    }