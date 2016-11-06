using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SetBuilder.Library
{
    [Serializable]
    [XmlType(TypeName = "KeyValuePair")]
    public class MyKeyValuePair<K, V>
    {
        public K Key { get; set; }

        public V Value { get; set; }

        public MyKeyValuePair() { }

        public MyKeyValuePair(K key, V val)
        {
            Key = key;
            Value = val;
        }
    }
}
