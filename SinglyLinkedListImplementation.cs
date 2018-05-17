using System;

namespace Learning
{
    class SinglyLinkedListImplementation
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddAtFront(12);
            list.AddAtFront(11);
            list.AddAtFront(10);
            list.AddFromLast(13);
            list.AddAtFront(9);
            list.AddFromLast(14);
            list.PrintLinkedList();
            list.PrintCurrentNode();
            Console.ReadKey();
        }
    }

    public class LinkedList
    {
        public LinkedList()
        {
            Head = new Node();
            CurrentNode = Head;
        }
        public Node CurrentNode { get; set; }
        public Node Head { get; set; }
        public int Count { get; set; }

        public void AddAtFront(object data)
        {
            Node newNode = new Node { Data = data };
            if (Head.Data == null)
            {
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

        public void AddFromLast(object data)
        {
            Node newNode = new Node {Data = data};
            if (Head.Data == null)
            {
                newNode.Next = Head.Next;
                Head = newNode;
                CurrentNode = newNode;
                Count++;
            }
            newNode.Next = CurrentNode.Next;
            CurrentNode.Next = newNode;
            CurrentNode = newNode;
            Count++;
        }

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

    }

    public class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
    }
}
