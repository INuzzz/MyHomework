using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class MyHashTable<T>
    {
        List<HashItem<T>>[] hasharray;
        public delegate int HashFDelegate(T val);
        HashFDelegate hashFunction;

        private int defaultHash(T val)
        {
            return val.GetHashCode();
        }

        public void setHash(HashFDelegate val)
        {
            hashFunction = val;
        }

        public MyHashTable(int n)
        {
            hashFunction = defaultHash;

            hasharray = new List<HashItem<T>>[n];
            for(int i=0; i < n; i++)
                hasharray[i] = new List<HashItem<T>>();
        }
        
        public void Add(T key, string value, int hashval)
        {
            HashItem<T> hashItem = new HashItem<T>(key, value);
            hashItem.HashValue = hashval;
            hasharray[hashItem.HashValue].Add(hashItem);
        }

        public HashItem<T> Find(T key)
        {
            foreach (HashItem<T> hashItem in hasharray[hashFunction(key)])
            {
                if (hashItem.Key.Equals(key))
                    return hashItem;
            }
            return null;
        }

        public void Delete(T key)
        {
            List<HashItem<T>> list = hasharray[hashFunction(key)];
            for (int i=0; i< list.Count; i++)
            {
                if (list[i].Key.Equals(key))
                {
                    hasharray[hashFunction(key)].Remove(list[i]);
                }
            }
        }

        public override string ToString()
        {
            string hashItems = "";
            foreach (List<HashItem<T>> hashList in hasharray)
            {
                hashItems += "\n";
                foreach (HashItem<T> hashItem in hashList)
                    hashItems += hashItem.Value.ToString() + "___" ;
            }
            return hashItems;
        }
    }
}
