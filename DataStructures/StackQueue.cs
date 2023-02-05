namespace DataStructures
{
    public class StackQueue
    {
        private Stack<int> stk1;
        private Stack<int> stk2;

        public StackQueue()
        {
            stk1 = new Stack<int>();
            stk2 = new Stack<int>();
        }

        public void Enqueue(int item)
        {
            stk1.Push(item);
        }

        public int Dequeue()
        {
            if (IsEmpty()) {
                throw new Exception("Queue is empty");
            }

            MoveStack1ToStack2();
            return stk2.Pop();
        }

        public int Peek()
        {
            if (IsEmpty()) {
                throw new Exception("Queue is empty");
            }

            MoveStack1ToStack2();
            return stk2.Peek();
        }

        private bool IsEmpty()
        {
            return stk1.Count == 0 && stk2.Count == 0;
        }

        private void MoveStack1ToStack2()
        {
            if (stk2.Count == 0) {
                while (stk1.Count != 0) {
                    stk2.Push(stk1.Pop());
                }
            }
        }
    }
}
