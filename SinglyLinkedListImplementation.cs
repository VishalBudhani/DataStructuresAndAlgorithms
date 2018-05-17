using System;

namespace Learning
{
    class SinglyLinkedListImplementation
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.DeleteFromFront();
            list.PrintLinkedList();
            list.AddAtFront(12);
            list.DeleteFromFront();
            list.PrintLinkedList();
            list.AddAtFront(12);
            list.DeleteFromEnd();
            list.PrintLinkedList();
            list.AddFromLast(12);
            list.AddAtFront(11);
            list.AddAtFront(10);
            list.AddFromLast(13);
            list.AddAtFront(9);
            list.AddFromLast(14);
            list.PrintLinkedList();
            list.PrintCurrentNode();
            list.DeleteFromEnd();
            list.PrintLinkedList();
            list.DeleteFromEnd();
            list.PrintLinkedList();
            list.PrintCurrentNode();
            list.DeleteFromFront();
            list.PrintLinkedList();
            list.PrintCurrentNode();
            Console.ReadKey();
        }
    }

    /// <summary>
    /// LinkedList Class
    /// </summary>
    public class LinkedList
    {
        //Constructor instantiates the head and sets the current node to head
        public LinkedList()
        {
            Head = new Node();
            CurrentNode = Head;
        }
        public Node CurrentNode { get; set; }
        public Node Head { get; set; }
        public int Count { get; set; }

        /// <summary>
        /// Adds the node at the front
        /// </summary>
        /// <param name="data"></param>
        public void AddAtFront(object data)
        {
            Node newNode = new Node { Data = data };
            // Head == null condition is added for the scenario when after 
            //LinkedList Instantiation, The head node is set to null
            if (Head == null || Head.Data == null)
            {
                if (Head == null)
                {
                    Head = new Node();
                    CurrentNode = Head;
                }
                // Its the first datanode
                newNode.Next = Head.Next;
                Head = newNode;
                CurrentNode = Head;
                Count++;

            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                Count++;
            }

        }

        /// <summary>
        /// Prints the Linkedlist nodes
        /// </summary>
        public void PrintLinkedList()
        {
            Console.WriteLine("Printing LinkedList");
            if (Count > 0)
            {
                var start = Head;
                while (start?.Data != null)
                {
                    Console.Write(start.Data + "-->");
                    start = start.Next;
                }
                if (start == null) // To Print Last Node
                {
                    Console.WriteLine("NULL");
                }
            }
            else
            {
                Console.WriteLine("LinkedList Is Empty");
            }
        }

        /// <summary>
        /// Adding at Last of the linkedlist
        /// </summary>
        /// <param name="data"></param>
        public void AddFromLast(object data)
        {
            Node newNode = new Node {Data = data};
            // Head == null condition is added for the scenario when after 
            //LinkedList Instantiation, The head node is set to null
            if (Head == null || Head.Data == null)
            {
                if (Head == null)
                {
                    Head = new Node();
                    CurrentNode = Head;
                }
                newNode.Next = Head.Next;
                Head = newNode;
                CurrentNode = newNode;
                Count++;
            }
            else
            {
                newNode.Next = CurrentNode.Next;
                CurrentNode.Next = newNode;
                CurrentNode = newNode;
                Count++;
            }
        }
        /// <summary>
        /// Prints the current node in the linkedlist
        /// </summary>
        public void PrintCurrentNode()
        {
            if (Count > 0)
            {
                Console.WriteLine("Current Node: " + CurrentNode.Data);
            }
            else
            {
               Console.WriteLine("Current Node is empty"); 
            }
        }
        /// <summary>
        /// Deletes the node from the end of linkedlist
        /// </summary>
        public void DeleteFromEnd()
        {
            Console.WriteLine("Deleting last node of linked list");
            if (Count > 0)
            {
                Node start = Head;
                if (Head.Next == null)
                {
                    Head = null;
                    CurrentNode = null;
                    Count--;
                }
                else
                {
                    Node current = null;
                    while (start.Next != null)
                    {
                        current = start;
                        start = current.Next;
                    }
                    current.Next = null;
                    CurrentNode = current;
                    Count--;
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
        /// <summary>
        /// Deletes the node from the front
        /// </summary>
        public void DeleteFromFront()
        {
            Console.WriteLine("Deleting from front");
            if (Count > 0)
            {
                if (Head.Next == null)
                {
                    Head = null;
                    CurrentNode = null;
                    Count--;
                }
                else
                {
                    Node start = Head;
                    Head = start.Next;
                    start = null;
                    Count--;
                }
            }
        }
        /// <summary>
        /// Prints the count of elements in LinkedList
        /// </summary>
        public void PrintCount()
        {
            Console.WriteLine("Total Count Is: " + Count);
        }
        /// <summary>
        /// Prints the head element of the linked list
        /// </summary>
        public void PrintHead()
        {
            Console.WriteLine("Head Node is: " + Head);
        }

    }

    /// <summary>
    /// Class defining node properties
    /// </summary>
    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
    }
}
