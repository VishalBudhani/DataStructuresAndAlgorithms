namespace TreeTraversal
{
    /// <summary>
    /// Creates input binary trees
    /// </summary>
    public class CreateBinarySearchTree
    {
        public static Node GetFirstTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            t.InsertData(55);
            t.InsertData(200);
            t.InsertData(198);
            t.InsertData(201);
            t.InsertData(209);
            t.InsertData(206);
            t.InsertData(211);
            t.InsertData(65);
            t.InsertData(56);
            return t.InsertData(57);
        }
        public static Node GetSecondTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            t.InsertData(55);
            t.InsertData(45);
            t.InsertData(35);
            t.InsertData(38);
            return t.InsertData(40);
        }
        public static Node GetThirdTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            t.InsertData(120);
            t.InsertData(160);
            t.InsertData(150);
            t.InsertData(148);
            t.InsertData(144);
            return t.InsertData(147);
        }
        public static Node GetFourthTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            t.InsertData(160);
            t.InsertData(190);
            t.InsertData(200);
            return t.InsertData(195);
        }
        public static Node GetFifthTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            t.InsertData(125);
            t.InsertData(110);
            return t.InsertData(130);
        }
        public static Node GetSixthTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            return t.InsertData(120);
        }
        public static Node GetSeventhTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            return t.InsertData(150);
        }
        public static Node GetEighthTree()
        {
            BinarySearchTree t = new BinarySearchTree();
            t.InsertData(140);
            t.InsertData(120);
            return t.InsertData(150);
        }
    }
}
