namespace DataStructures
{
    public class ArrayDs<T>
        where T : struct
    {
        private T[] _array;
        private int _count = 0;

        /// <summary>
        /// Define length of array at object initialization
        /// </summary>
        /// <param name="length"></param>
        public ArrayDs(int length)
        {
            _array = new T[length];
        }

        /// <summary>
        /// Insert a new item into an array
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            if (_count == _array.Length) {
                var oldArray = _array;
                _array = new T[_count * 2];
                for (int i = 0; i < _count; i++) {
                    _array[i] = oldArray[i];
                }
            }
            _array[_count++] = item;
        }

        /// <summary>
        /// Remove element from specific index of array
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="Exception"></exception>
        public void RemoveAt(int index)
        {
            if (index >= _count || index < 0) {
                throw new Exception("Index out of range");
            }
            for (int y = index; y < _count; y++) {
                _array[y] = _array[y + 1];
            }
            _count--;
        }

        /// <summary>
        /// Get data from specific index of array
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int IndexOf(T item)
        {
            for (int u = 0; u < _count; u++) {
                if (_array[u].ToString() == item.ToString()) {
                    return u;
                }
            }
            return -1;
        }

        /// <summary>
        /// Print all the elements of array
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < _count; i++) {
                Console.WriteLine(_array[i]);
            }
        }
    }
}
