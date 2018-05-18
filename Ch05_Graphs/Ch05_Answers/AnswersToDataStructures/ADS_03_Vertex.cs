using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    public class Vertex<T, K>
    {
        private Node<T> _start;
        private Node<T> _end;
        private K _weight;

        public K Weight { get { return _weight; } }
        public Node<T> Start { get { return _start; } }
        public Node<T> End { get { return _end; } }
        
        public Vertex(Node<T> start, Node<T> end, K Weight)
        {
            this._start = start;
            this._end = end;
            this._weight = Weight;
        }
    }
}
