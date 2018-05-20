using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    public class Tree<T>
    {
        private TreeNode<T> _root;

        public TreeNode<T> Root { get { return this._root; } }

        public Tree(T item)
        {
            TreeNode<T> node = new TreeNode<T>(item);
            this._root = node;
        }

        public Tree(TreeNode<T> root)
        {
            this._root = root;
        }
    }


    public static class AutoCreateTrees
    {
        #region AutoCreate methods

        /// <summary>
        /// Create the DAG tree based in the book
        /// </summary>
        /// <returns></returns>
        public static Tree<string> AutoCreateTree_01_DAG_AQ10()
        {
            TreeNode<string> root = new TreeNode<string>("+");
            root.Left = new TreeNode<string>("+");
            root.Right = new TreeNode<string>("/");

            TreeNode<string> left01 = root.Left;
            left01.Left = new TreeNode<string>("2");
            left01.Right = new TreeNode<string>("*");

            TreeNode<string> right_lvl_01 = root.Right;
            right_lvl_01.Left = left01.Right;
            right_lvl_01.Right = new TreeNode<string>("5");

            TreeNode<string> middle_lvl_02 = right_lvl_01.Left;
            middle_lvl_02.Left = new TreeNode<string>("3");
            middle_lvl_02.Right = new TreeNode<string>("4");

            Tree<string> tree = new Tree<string>(root);

            return tree;
        }

        #endregion
    }
}
