using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    public class TreeNode<T>
    {
        private T _item;

        public T Item { get { return _item; } }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T item)
        {
            this._item = item;
        }

        public void SetItem(T item)
        {
            this._item = item;
        }
    }
}
