using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class LRUCache
    {
        private Dictionary<int, LinkedListNode<(int key, int value)>> _dict = new();
        private LinkedList<(int key, int value)> _value = new();
        private int _capacity;
        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            if(!_dict.ContainsKey(key))
            {
                return -1;
            }
            var node= _dict[key];
            _value.Remove(node);
            _value.AddFirst(node);

            return node.Value.value;
        }

        public void Put(int key, int value)
        {
            if (!_dict.ContainsKey(key) && _dict.Count >= _capacity)
            {
                var node = _value.Last;
                _dict.Remove(node.Value.key);
                _value.Remove(node);
            }

            var existingNode = _dict.GetValueOrDefault(key);
            if (existingNode != null)
            {
                _value.Remove(existingNode);
            }
            _value.AddFirst((key, value));
            _dict[key] = _value.First;
        }
    }
}
