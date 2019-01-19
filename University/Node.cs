using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
    [System.Serializable]
    class Node<T>
    {

        public T info;
        public Node<T> next = null;
    }
}
