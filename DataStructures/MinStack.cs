namespace DataStructures
{
    public class MinStack
    {
        private int[] stk;
        private int count;
        private int minElement;

        public MinStack(int size)
        {
            stk = new int[size];
            count = 0;
        }

        public void Push(int item)
        {
            if (IsFull()) {
                throw new Exception("Stack is full");
            }

            if (IsEmpty()) {
                minElement = item;
                stk[count++] = item;
            }
            else if (item < minElement) {
                stk[count++] = 2 * item - minElement;
                minElement = item;
            }
            else {
                stk[count++] = item;
            }
        }

        public int Pop()
        {
            if (IsEmpty()) {
                throw new Exception("Stack is empty");
            }

            var top = stk[--count];

            if (top < minElement) {
                minElement = 2 * minElement - top;
            }

            return top;
        }

        public int Min()
        {
            if (IsEmpty()) {
                return default;
            }

            return minElement;
        }

        private bool IsFull()
        {
            return stk.Length == count;
        }

        private bool IsEmpty()
        {
            return count == 0;
        }
    }
}
