using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    public class Node<T>
    {
        private T _id;
        private LinkedList<Node<T>> _adjacent;

        public T Id { get { return this._id; } }
        public LinkedList<Node<T>> Adjacent { get { return this._adjacent; } }

        public Node(T id)
        {
            this._id = id;
            this._adjacent = new LinkedList<Node<T>>();
        }

        public void AddNeighbor(Node<T> neighbor)
        {
            _adjacent.AddLast(neighbor);
        }
    }

    public static class NodeHelper
    {
        public static Node<T> GetNode<T>(T id, Dictionary<T, Node<T>> nodeLookup)
        {
            if (nodeLookup.ContainsKey(id))
            {
                return nodeLookup.Single(x => x.Key.ToString() == id.ToString()).Value;
            }
            else
            {
                return null;
            }
        }

        public static Node<T> GetOrAddNode<T>(T id, Dictionary<T, Node<T>> nodeLookup)
        {
            if (nodeLookup.ContainsKey(id))
            {
                return nodeLookup.Single(x => x.Key.ToString() == id.ToString()).Value;
            }
            else
            {
                Node<T> node = new Node<T>(id);
                nodeLookup.Add(id, node);
                return node;
            }
        }
    }
}
