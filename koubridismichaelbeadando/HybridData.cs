using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koubridismichaelbeadando
{
    public class HybridData
    {
        private HybridDictionary data;

        public HybridData()
        {
            data = new HybridDictionary();
        }

        public void Add(string key, object value)
        {
            data.Add(key, value);
        }

        public void Remove(string key)
        {
            if (data.Contains(key))
            {
                data.Remove(key);
            }
        }

        public object Get(string key)
        {
            if (data[key] is not null)
            {
                return data[key];
            }
            else
            {
                throw new Exception($"A {key} kulcsnak nincs értéke.");
            }
        }

        public void Clear()
        {
            data.Clear();
        }

        public int Count()
        {
            return data.Count;
        }

        public bool Contains(string key)
        {
            return data.Contains(key);
        }

        public IEnumerable GetAllKeys()
        {
            foreach (var key in data.Keys)
            {
                yield return key;
            }
        }

        public IEnumerable GetKeysUntil(string stopKey)
        {
            foreach (var key in data.Keys)
            {
                if (key.ToString() == stopKey)
                    yield break;
                yield return key;
            }
        }
    }
}
