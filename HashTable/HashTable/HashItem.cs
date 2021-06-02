using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class HashItem<T>
    {
        public T Key { get; set; }
        public string Value { get; set; }
        public int HashValue { get; set; }

        public HashItem(T key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}
