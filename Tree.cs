using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters;

namespace BinaryTree
{
    public class Tree<T>
    {
        private readonly TreeNode<T> _root;
        public Tree(T inputData)
        {
            if (inputData == null)
            {
                throw new ArgumentNullException("Null not allowed");
            }
            _root = new TreeNode<T>(inputData);
        }
        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                _root.AddChild(child._root);
            }
        }
        
        private void Print(TreeNode<T> root, string spaces)
        {
            if (this._root == null)
            {
                return;
            }
            Console.WriteLine(spaces + root.Value);
            TreeNode<T> child = null;
            for (var i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                Print(child, spaces + " ");
            }
        }
        public void Traverse()
        {
            Print(_root, string.Empty);
        }
    }

}