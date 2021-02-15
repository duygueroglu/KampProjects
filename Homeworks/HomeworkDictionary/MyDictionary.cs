using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkDictionary
{
    class MyDictionary<Key,Value>
    {
        List<Key> keys;
        List<Value> values;

        public MyDictionary()
        { 
            values = new List<Value>();
            keys = new List<Key>();
        }

        public void Add(Key key, Value value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public void Keys(Key key)
        {
            try
            {
                Console.WriteLine(values[keys.IndexOf(key)]);
            }
            catch
            {
                Console.WriteLine("Word doesn't exist.");
            }
        }
    }
}
