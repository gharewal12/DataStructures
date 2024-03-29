﻿namespace DataStructures
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
        /// Get kth node from end of linked list
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int GetKthNodeFromEnd(int k)
        {
            var temp1 = first;
            var temp2 = first;

            if (IsEmpty()) {
                throw new Exception("Linked list is empty.");
            }

            while (k > 1) {
                temp1 = temp1.next;
                k--;
                if (temp1 == null) {
                    throw new Exception("k is greater that size of linked array.");
                }
            }

            while (temp1 != last) {
                temp1 = temp1.next;
                temp2 = temp2.next;
            }

            return temp2.value;
        }

        /// <summary>
        /// Print the middle element of the linked list
        /// </summary>
        public void PrintMiddle()
        {
            if (IsEmpty()) {
                throw new Exception("Empty list");
            }
            var a = first;
            var b = first;

            while (b != last && b.next != last) {
                b = b.next.next;
                a = a.next;
            }

            if (b == last) {
                Console.WriteLine(a.value);
            }
            else {
                Console.WriteLine(a.value + ", " + a.next.value);
            }
        }

        /// <summary>
        /// Detect if there is a loop in linked list
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool HasLoop()
        {
            if (IsEmpty()) {
                throw new Exception("Linked list is empty.");
            }
            var a = first;
            var b = first;

            while (b != last && b.next != last) {
                b = b.next.next;
                a = a.next;

                if (a == b) {
                    return true;
                }
            }

            return false;
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
        public bool IsEmpty()
        {
            return first == null;
        }

        /// <summary>
        /// Return value of last node
        /// </summary>
        /// <returns></returns>
        public int GetLastNodeValue()
        {
            return last.value;
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
