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

        /// <summary>
        /// Get maximum value
        /// </summary>
        /// <returns></returns>
        public T Max()
        {
            T max = default;

            for (int i = 0; i < _array.Length; i++) {
                if (Convert.ToInt32(_array[i].ToString()) > Convert.ToInt32(max.ToString())) {
                    max = _array[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Get common elements between 2 arrays
        /// </summary>
        /// <param name="array2"></param>
        /// <returns></returns>
        public ArrayDs<T> Intersect(ArrayDs<T> array2)
        {
            var result = new ArrayDs<T>(array2._count > _array.Length ? _array.Length : array2._count);
            for (int i = 0; i < _array.Length; i++) {
                for (int j = 0; j < array2._count; j++) {
                    if (_array[i].ToString() == array2._array[j].ToString()) {
                        result.Insert(_array[i]);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Reverse the elements of array
        /// </summary>
        public void Reverse()
        {
            var temp = new T[_array.Length];

            for (int i = 0; i < _count; i++) {
                temp[i] = _array[_count - i - 1];
            }

            _array = temp;
        }

        /// <summary>
        /// Insert element at specified index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="item"></param>
        /// <exception cref="Exception"></exception>
        public void InsertAt(int index, T item)
        {
            if (index > _array.Length) {
                throw new Exception("Index out of range");
            }

            if (index > _count) {
                index = _count;
            }

            var newArray = new T[_count + 1];
            for (int i = 0; i < index; i++) {
                newArray[i] = _array[i];
            }
            newArray[index] = item;
            for (int i = index + 1; i < _count + 1; i++) {
                newArray[i] = _array[i - 1];
            }
            _array = newArray;
            _count++;
        }
    }
}
