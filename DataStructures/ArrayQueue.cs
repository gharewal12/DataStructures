namespace DataStructures
{
    public class ArrayQueue
    {
        private int[] items;
        private int front;
        private int rear;
        private int count;

        public ArrayQueue(int size)
        {
            items = new int[size];
            front = 0;
            rear = 0;
        }

        /// <summary>
        /// Insert item into queue
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="Exception"></exception>
        public void Enqueue(int item)
        {
            if (IsFull()) {
                throw new Exception("Queue is full");
            }
            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }

        /// <summary>
        /// Remove front item from queue
        /// </summary>
        /// <exception cref="Exception"></exception>
        public int Dequeue()
        {
            if (IsEmpty()) {
                throw new Exception("Queue is empty");
            }
            var item = items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;

        }

        /// <summary>
        /// Get the value of front item of queue
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Peek()
        {
            if (IsEmpty()) {
                throw new Exception("Queue is empty");
            }
            return items[front];
        }

        /// <summary>
        /// To check if queue is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return count == items.Length;
        }

        /// <summary>
        /// To check if queue is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
