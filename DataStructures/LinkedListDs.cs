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
        private int count;

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
            count++;
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
            count++;
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

            count--;
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

            count--;
            if (first == last) {
                first = last = null;
                return;
            }
            var previous = GetPrevious(last);
            previous.next = null;
            last = previous;
        }

        /// <summary>
        /// Return size of the linked list
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return count;
        }

        /// <summary>
        /// Convert linked list into an array
        /// </summary>
        /// <returns></returns>
        public int[] ToArray()
        {
            var array = new int[count];
            var index = 0;
            var temp = first;

            while (temp != null) {
                array[index++] = temp.value;
                temp = temp.next;
            }

            return array;
        }

        /// <summary>
        /// Reverse the elements of linked list
        /// </summary>
        public void Reverse()
        {
            var previous = first;
            var current = first.next;

            while (current != null) {
                var next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            last = first;
            last.next = null;
            first = previous;
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
