using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
    // internal nodes: only use key and next
    // external nodes: only use key and address
    public class Entry
    {
        public string key;
        public string address;
        public Node next;     // helper field to iterate over array entries
        public Entry(string key, string address, Node next)
        {
            this.key = key;
            this.address = address;
            this.next = next;
        }
    }
}
