namespace DataStructures
{
    public class BinaryTree
    {
        private class Node
        {
            public int value { get; set; }
            public Node left { get; set; }
            public Node right { get; set; }

            public Node(int value)
            {
                this.value = value;
            }
            public override string ToString()
            {
                return "Node=" + value;
            }

        }

        private Node root;

        public void Insert(int value)
        {
            InsertNode(value, root);
        }

        private Node InsertNode(int value, Node node)
        {
            if (root == null) {
                root = new Node(value);
                return root;
            }

            if (node == null) {
                return new Node(value);
            }

            if (value < node.value) {
                //go to left
                node.left = InsertNode(value, node.left);
            }
            else if (value > node.value) {
                // go to right
                node.right = InsertNode(value, node.right);

            }
            return node;
        }
    }
}
