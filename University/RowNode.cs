using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityClasses
{
    [System.Serializable]
    class RowNode<T> : Node<T>
    {
        public RowNode<T> nextRow = null;
    }
}
