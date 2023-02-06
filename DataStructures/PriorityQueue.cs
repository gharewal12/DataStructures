namespace DataStructures
{
    public class PriorityQueue
    {
        private int[] items;
        private int count;
        private int rear;

        public PriorityQueue(int size)
        {
            items = new int[size];
            rear = 0;
        }

        public void Enqueue(int item)
        {
            if (IsFull()) {
                throw new Exception("Queue is full");
            }

            if (count == 0) {
                items[rear] = item;
            }
            else {
                if (items[rear - 1] < item) {
                    items[rear] = item;
                }
                else {
                    var index = ShiftItemsToInsert(item);
                    items[index] = item;
                }
            }
            rear = (rear + 1) % items.Length;
            count++;
        }

        public int Dequeue()
        {
            if (IsEmpty()) {
                throw new Exception("Queue is empty");
            }

            return items[--count];
        }

        public bool IsFull()
        {
            return count == items.Length;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        private int ShiftItemsToInsert(int item)
        {
            int i;
            for (i = rear - 1; i >= 0; i--) {
                if (items[i] > item) {
                    items[i + 1] = items[i];
                }
                else {
                    break;
                }
            }
            return i + 1;
        }
    }
}
