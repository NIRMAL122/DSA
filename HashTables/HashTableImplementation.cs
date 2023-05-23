using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class MyNode
    {
        public string key { get; set; }
        public int value { get; set; }
        public MyNode(string _key, int _value)
        {
            this.key = _key;
            this.value = _value;
                
        }
    }


    public class HashTableImplementation
    {
        private class MyNodes: List<MyNode> { }
        private int length;
        private MyNodes[] data;

        public HashTableImplementation(int size)
        {
            this.length = size;
            this.data=new MyNodes[size];

        }

        private int hash(string key)
        {
            int hash = 0;
            for(int i=0;i<key.Length;i++)
            {
                hash = (hash + (int)key[i] * i) % this.length;
            }
            return hash;
        }

        public void set(string key, int value)
        {
            int index = hash(key);
            if (this.data[index] == null)
            {
                this.data[index]=new MyNodes();
            }
            this.data[index].Add(new MyNode(key, value));
        }

        public int get(string key)
        {
            int index= hash(key);
            if (this.data[index] == null)
            {
                return 0;
            }
            foreach(var node in this.data[index])
            {
                if (node.key.Equals(key))
                {
                    return node.value;
                }
            }
            return 0;
        }
    }
}
