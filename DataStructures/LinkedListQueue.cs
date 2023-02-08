namespace DataStructures
{
    public class LinkedListQueue
    {
        private LinkedListDs ll;

        public LinkedListQueue()
        {
            ll = new LinkedListDs();
        }

        //O(1)
        /// <summary>
        /// Adding queue element
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(int item)
        {
            ll.AddFirst(item);
        }

        //O(1)
        /// <summary>
        /// Removing the first element from queue
        /// </summary>
        /// <returns></returns>
        public int Dequeue()
        {
            if (IsEmpty()) {
                throw new Exception("Queue is empty");
            }

            var last = ll.GetLastNodeValue();
            ll.RemoveLast();
            return last;

        }

        //O(1)
        /// <summary>
        /// Return first element of the queue
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return ll.GetLastNodeValue();
        }

        //O(1)
        /// <summary>
        /// Reutrns size of the queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return ll.Size();
        }

        //O(1)
        /// <summary>
        /// Return true if queue is empty else false
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return ll.IsEmpty();
        }
    }
}
