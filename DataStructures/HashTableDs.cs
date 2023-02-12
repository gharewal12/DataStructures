using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private int count;

        public HashTableDs(int size)
        {
            items = new LinkedList<KeyValuePair>[size];
        }

        public void Put(int key, string value)
        {
            var index = Hash(key);

            if (items[index] == null) {
                items[index] = new LinkedList<KeyValuePair>();
            }

            var entries = items[index];

            foreach (var item in entries) {
                if (item._key == key) {
                    item._value = value;
                    return;
                }
            }

            entries.AddLast(new KeyValuePair(key, value));
        }

        public string Get(int key)
        {
            var index = Hash(key);
            var entries = items[index];

            if (entries != null) {
                foreach (var item in entries) {
                    if (item._key == key) {
                        return item._value;
                    }
                }
            }

            return null;
        }

        public void Remove(int key)
        {
            var index = Hash(key);
            var entries = items[index];

            if (entries == null) {
                throw new Exception("Entry not found");
            }

            foreach (var item in entries) {
                if (item._key == key) {
                    entries.Remove(item);
                    return;
                }
            }

            throw new Exception("Entry not found");
        }

        private int Hash(int key)
        {
            return key % items.Length;
        }
    }
}
