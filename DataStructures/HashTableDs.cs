namespace DataStructures
{
    public class HashTableDs
    {
        private class KeyValuePair
        {
            public int _key;
            public string _value;
            public KeyValuePair(int key, string value)
            {
                _key = key;
                _value = value;
            }
        }

        private LinkedList<KeyValuePair>[] items;

        public HashTableDs(int size)
        {
            items = new LinkedList<KeyValuePair>[size];
        }

        public void Put(int key, string value)
        {
            var entry = GetEntry(key);

            if (entry != null) {
                entry._value = value;
                return;
            }

            GetOrCreateEntry(key).AddLast(new KeyValuePair(key, value));
        }

        public string Get(int key)
        {
            var entry = GetEntry(key);

            return entry == null ? null : entry._value;
        }

        public void Remove(int key)
        {
            var entry = GetEntry(key);

            if (entry == null) {
                throw new Exception("Empty hash table");
            }

            GetEntries(key).Remove(entry);
        }

        private int Hash(int key)
        {
            return key % items.Length;
        }

        private KeyValuePair GetEntry(int key)
        {
            var entries = GetEntries(key);

            if (entries != null) {
                foreach (var item in entries) {
                    if (item._key == key) {
                        return item;
                    }
                }
            }

            return null;
        }

        private LinkedList<KeyValuePair> GetEntries(int key)
        {
            return items[Hash(key)];
        }

        private LinkedList<KeyValuePair> GetOrCreateEntry(int key)
        {
            var index = Hash(key);
            var entries = items[index];
            if (entries == null) {
                items[index] = new LinkedList<KeyValuePair>();
            }

            return items[index];
        }
    }
}
