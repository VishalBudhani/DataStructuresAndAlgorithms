using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Pre Order Traversal
/// </summary>
namespace TreeTraversal
{
    public class PerformPreOrder
    {
        public static void PreOrderRecursion(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.NodeData + " ");
            PreOrderRecursion(root.Left);
            PreOrderRecursion(root.Right);
        }

        public static void PreOrderIterative(Node root)
        {
            if (root == null)
                return;

            Stack <Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                Console.Write(currentNode.NodeData + " ");
                if (currentNode.Right != null)
                    stack.Push(currentNode.Right);
                if(currentNode.Left != null)
                    stack.Push(currentNode.Left);
            }
        }
    }
}
