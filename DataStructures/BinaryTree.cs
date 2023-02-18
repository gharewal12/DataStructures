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

        public bool Find(int value)
        {
            return FindValue(value, root);
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

        private bool FindValue(int value, Node node)
        {
            if (root == null) {
                throw new Exception("Tree is empty");
            }

            if (node == null) {
                return false;
            }

            if (value == node.value) {
                return true;
            }

            if (value < node.value) {
                return FindValue(value, node.left);
            }
            else if (value > node.value) {
                return FindValue(value, node.right);
            }

            return false;
        }
    }
}
