using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            var bst1 = CreateBinarySearchTree.GetFirstTree();
            var bst2 = CreateBinarySearchTree.GetSecondTree();
            var bst3 = CreateBinarySearchTree.GetThirdTree();
            var bst4 = CreateBinarySearchTree.GetFourthTree();
            var bst5 = CreateBinarySearchTree.GetFifthTree();
            var bst6 = CreateBinarySearchTree.GetSixthTree();
            var bst7 = CreateBinarySearchTree.GetSeventhTree();
            var bst8 = CreateBinarySearchTree.GetEighthTree();
            List<Node> list = new List<Node>
            {
                bst1, bst2, bst3, bst4, bst5, bst6, bst7, bst8
            };

            Console.WriteLine("Performing Traversals");

            for (int i = 1; i <= 8; i++)
            {
                var rootNode = list[i - 1];
                Console.WriteLine("*************************************************************");
                Console.WriteLine("Recursive Preorder traversal of bst" + i + " is:");

                PerformPreOrder.PreOrderRecursion(rootNode);
                Console.WriteLine();

                Console.WriteLine("Iterative Preorder traversal of bst" + i + " is:");
                PerformPreOrder.PreOrderRecursion(rootNode);
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                Console.WriteLine("Recursive Inorder traversal of bst" + i + " is:");
                PerformInorder.InorderRecursive(rootNode);
                Console.WriteLine();

                Console.WriteLine("Iterative InOrder traversal of bst" + i + " is:");
                PerformInorder.InorderIterative(rootNode);
                Console.WriteLine();

                Console.WriteLine("##############################################################");
                Console.WriteLine("Recursive PostOrder traversal of bst" + i + " is:");
                PerformPostOrder.RecursivePostOrder(rootNode);
                Console.WriteLine();

                Console.WriteLine("Iterative PostOrder traversal of bst{0} using single stack is:", i);
                PerformPostOrder.IterativePostOrderSingleStack(rootNode);
                Console.WriteLine();

                Console.WriteLine("Iterative PostOrder traversal of bst{0} using two stacks is:", i);
                PerformPostOrder.IterativePostOrderTwoStacks(rootNode);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("##############################################################");
            for (int i=1; i<=list.Count(); i++)
            {
                Console.WriteLine("Morris Algo InOrder traversal of bst" + i + " is:");
                PerformInorder.InorderTraversalMorrisAlgorithm(list[i - 1]);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    
}
