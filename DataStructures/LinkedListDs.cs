namespace DataStructures
{
    public class LinkedListDs
    {
        private class Node
        {
            public int value;
            public Node next;

            public Node(int item)
            {
                value = item;
            }
        }

        private Node first;
        private Node last;

        /// <summary>
        /// Add element at the end of linked list
        /// </summary>
        /// <param name="item"></param>
        public void AddLast(int item)
        {
            var node = new Node(item);

            if (IsEmpty()) {
                first = last = node;
            }
            else {
                last.next = node;
                last = node;
            }
        }

        /// <summary>
        /// Add element at the start of linked list
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(int item)
        {
            var node = new Node(item);
            if (IsEmpty()) {
                first = last = node;
            }
            else {
                node.next = first;
                first = node;
            }
        }

        /// <summary>
        /// Return the index of element in linked list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(int item)
        {
            var temp = first;
            var index = 0;
            while (temp != null) {
                if (temp.value == item) {
                    return index;
                }
                temp = temp.next;
                index++;
            }

            return -1;
        }

        /// <summary>
        /// Check if item exist in linked list
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }

        /// <summary>
        /// Remove first item from linked list
        /// </summary>
        public void RemoveFirst()
        {
            if (IsEmpty()) {
                throw new Exception("Empty Linked List");
            }

            //If list has only one element
            if (first == last) {
                first = last = null;
                return;
            }
            var second = first.next;
            first.next = null;
            first = second;
        }

        /// <summary>
        /// Remove last element of the linked list
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void RemoveLast()
        {
            if (IsEmpty()) {
                throw new Exception("Empty Linked List");
            }
            if (first == last) {
                first = last = null;
                return;
            }
            var previous = GetPrevious(last);
            previous.next = null;
            last = previous;
        }

        /// <summary>
        /// Print all items of linked list
        /// </summary>
        public void Print()
        {
            var temp = first;

            while (temp != null) {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }

        /// <summary>
        /// To check if linked list is empty
        /// </summary>
        /// <returns></returns>
        private bool IsEmpty()
        {
            return first == null;
        }

        /// <summary>
        /// Get previous node of the specified node.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private Node GetPrevious(Node node)
        {
            var temp = first;
            while (temp != null) {
                if (temp.next == node) {
                    return temp;
                }
                temp = temp.next;
            }

            return null;
        }
    }
}
