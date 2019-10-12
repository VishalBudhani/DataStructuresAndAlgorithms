using System;
using System.Collections.Generic;

/// <summary>
/// Inorder traversal
/// </summary>
namespace TreeTraversal
{
    public class PerformInorder
    {
        public static void InorderRecursive(Node root)
        {
            if (root == null)
                return; 
            InorderRecursive(root.Left);
            Console.Write(root.NodeData + " ");
            InorderRecursive(root.Right);
        }

        public static void InorderIterative(Node root)
        {
            if (root == null)
                return;
            Stack<Node> inputStack = new Stack<Node>();
            Node currentNode = root;
            while (true)
            {
                while (currentNode != null)
                {
                    inputStack.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                var data = inputStack.Pop();
                Console.Write(data.NodeData + " ");
                currentNode = data.Right;
                if (inputStack.Count == 0 && currentNode == null)
                    break;
            }
        }

        public static void InorderTraversalMorrisAlgorithm(Node root)
        {
            var current = root;
            if (current == null)
                return;

            while (current != null)
            {
                if (current.Left == null)
                {
                    Console.Write(current.NodeData + " ");
                    current = current.Right;
                }
                while (current != null)
                {
                    var p = current.Left;
                    while (p != null &&
                           p.Right != current && p.Right != null)
                    {
                        p = p.Right;
                    }
                    if (p != null && p.Right == null)
                    {
                        p.Right = current;
                        if (current.Left != null)
                        {
                            current = current.Left;
                        }
                        else
                        {
                            Console.Write(current.NodeData + " ");
                            current = current.Right;
                        }
                    }
                    else if (p == null || p.Right == current)
                    {
                        Console.Write(current.NodeData + " ");
                        current = current.Right;
                    }
                }
            }
        }
    }
}
