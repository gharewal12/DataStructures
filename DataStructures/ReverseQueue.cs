using System.Collections;

namespace DataStructures
{
    public static class ReverseQueue
    {
        public static Queue Reverse(Queue queue)
        {
            var stack = new Stack();

            while (queue.Count != 0) {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count != 0) {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }
    }
}
