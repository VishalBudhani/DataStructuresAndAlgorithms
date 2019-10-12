using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public Node InsertData(int dataToInsert)
        {
            if (Root == null)
            {
                Root = new Node
                {
                    NodeData = dataToInsert
                };
            }
            else
            {
                Node currentNode = Root;
                Node parentNode = null;
                while (true)
                {
                    if (dataToInsert > currentNode.NodeData)
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.Right;
                        if (currentNode == null)
                        {
                            currentNode = new Node
                            {
                                NodeData = dataToInsert
                            };
                            parentNode.Right = currentNode;
                            break;
                        }
                    }
                    else
                    {
                        parentNode = currentNode;
                        currentNode = currentNode.Left;
                        if (currentNode == null)
                        {
                            currentNode = new Node
                            {
                                NodeData = dataToInsert
                            };
                            parentNode.Left = currentNode;
                            break;
                        }
                    }
                }
            }
            return Root;
        }
    }

    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int NodeData { get; set; }
    }
}
