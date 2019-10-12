using System;
using System.Collections.Generic;

/// <summary>
/// PostOrder Traversal
/// </summary>
namespace TreeTraversal
{
    public class PerformPostOrder
    {
        public static void RecursivePostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }                
            RecursivePostOrder(root.Left);
            RecursivePostOrder(root.Right);
            Console.Write(root.NodeData + " ");
        }

        public static void IterativePostOrderSingleStack(Node root)
        {
            if (root == null)
                return;
            Stack<Node> inputStack = new Stack<Node>();
            Node currentNode = root;
            Node lastPrinted = null;
            while (true)
            {
                while (currentNode != null)
                {
                    inputStack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                
                //Check if the right of the leftmost node is null
                if (inputStack.Peek().Right == null)
                {
                    lastPrinted = inputStack.Pop();
                    Console.Write(lastPrinted.NodeData + " ");
                }

                //check if the leftmost node has a right neighbour 
                //and the right neighbour is not printed yet
                if (inputStack.Count > 0 && 
                    inputStack.Peek().Right != null && 
                    lastPrinted != inputStack.Peek().Right)
                {
                    currentNode = inputStack.Peek().Right;
                    continue;
                }

                if (inputStack.Count == 0)
                    break;

                // if the right neighbor is printed then remove the node
                lastPrinted = inputStack.Pop();
                Console.Write(lastPrinted.NodeData + " ");
                
                if (inputStack.Count == 0)
                    break;
            }
        }

        public static void IterativePostOrderTwoStacks(Node root)
        {
            if (root == null)
                return;
            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            stack1.Push(root);
            while (stack1.Count > 0)
            {
                var poppedItem = stack1.Pop();
                stack2.Push(poppedItem);
                if(poppedItem.Left != null)
                    stack1.Push(poppedItem.Left);
                if(poppedItem.Right != null)
                    stack1.Push(poppedItem.Right);
            }
            while (stack2.Count > 0)
            {
                Console.Write(stack2.Pop().NodeData + " ");
            }
        }
    }
}
