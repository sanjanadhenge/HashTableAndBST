using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
   
        public class MyMapNode<K, V>
        {
            private readonly int size;
            private readonly LinkedList<KeyValue<K, V>>[] items;
            public MyMapNode(int size)
            {
                this.size = size;
                this.items = new LinkedList<KeyValue<K, V>>[size];
            }
            protected int GetArrayPosition(K Key)
            {
                int position = Key.GetHashCode() % size;
                return Math.Abs(position);
            }
            public V Get(K Key)
            {
                int position = GetArrayPosition(Key);
                LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
                foreach (KeyValue<K, V> item in linkedlist)
                {
                    if (item.Key.Equals(Key))
                    {
                        return item.Value;
                    }
                }
                return default(V);
            }
            public void Add(K key, V value)
            {
                int position = GetArrayPosition(key);
                LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
                KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
                linkedlist.AddLast(item);
            }
           
            public void Remove(K key)
            {
                int position = GetArrayPosition(key);
                LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(position);
                bool itemfound = false;
                KeyValue<K, V> founditem = default(KeyValue<K, V>);
                foreach (KeyValue<K, V> item in linkedlist)
                {
                    if (item.Key.Equals(key))
                    {
                        itemfound = true;
                        founditem = item;
                    }
                }
                if (itemfound)
                {
                    linkedlist.Remove(founditem);
                }
            }
            protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
            {
                LinkedList<KeyValue<K, V>> linkedlist = items[position];
                if (linkedlist == null)
                {
                    linkedlist = new LinkedList<KeyValue<K, V>>();
                    items[position] = linkedlist;
                }
                return linkedlist;
            }
            public struct KeyValue<K, V>
            {
                public K Key { get; set; }
                public V Value { get; set; }
            }
        }

    
}
