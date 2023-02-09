namespace DataStructures
{
    public class StackWithTwoQueues
    {

        private Queue<int> q1;
        private Queue<int> q2;

        public StackWithTwoQueues()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        public void Push(int x)
        {
            q2.Enqueue(x);

            while (q1.Count > 0) {
                q2.Enqueue(q1.Dequeue());
            }

            var q = q1;
            q1 = q2;
            q2 = q;
        }

        public int Pop()
        {
            if (q1.Count == 0) {
                return -1;
            }
            return q1.Dequeue();
        }

        public int Peek()
        {
            if (q1.Count == 0) {
                return -1;
            }

            return q1.Peek();
        }

        public int Size()
        {
            return q1.Count;
        }

        public bool IsEmpty()
        {
            return q1.Count == 0;
        }
    }
}
