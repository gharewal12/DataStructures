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

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        public void InOrderTraverse()
        {
            InOrderTraverse(root);
        }

        public void PostOrderTraverse()
        {
            PostOrderTraverse(root);
        }

        public int Height()
        {
            return Height(root);
        }

        public int Min()
        {
            return Min(root);
        }

        public bool Equals(BinaryTree tree)
        {
            if (tree == null) {
                return false;
            }

            return Equals(root, tree.root);
        }

        private void TraversePreOrder(Node root)
        {
            if (root == null) {
                return;
            }

            Console.WriteLine(root.value);
            TraversePreOrder(root.left);
            TraversePreOrder(root.right);
        }

        private void InOrderTraverse(Node root)
        {
            if (root == null) {
                return;
            }

            InOrderTraverse(root.left);
            Console.WriteLine(root.value);
            InOrderTraverse(root.right);
        }

        private void PostOrderTraverse(Node root)
        {
            if (root == null) {
                return;
            }

            PostOrderTraverse(root.left);
            PostOrderTraverse(root.right);
            Console.WriteLine(root.value);
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

        private int Height(Node root)
        {
            if (root == null) {
                return -1;
            }

            if (IsLeafNode(root)) {
                return 0;
            }

            return 1 + Math.Max(Height(root.left), Height(root.right));
        }

        private int Min(Node root)
        {
            if (IsLeafNode(root)) {
                return root.value;
            }

            var left = Min(root.left);
            var right = Min(root.right);

            return Math.Min(Math.Min(left, right), root.value);
        }

        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null) {
                return true;
            }

            if (first != null && second != null) {
                return first.value == second.value && Equals(first.left, second.left) && Equals(first.right, second.right);
            }

            return false;
        }

        private bool IsLeafNode(Node node)
        {
            return node.left == null && node.right == null;
        }
    }
}
