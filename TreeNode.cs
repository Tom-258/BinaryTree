using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class TreeNode<T>
    {
        private bool hasParent;
        private readonly List<TreeNode<T>> _childNodes;
        public TreeNode(T inputData)
        {
            if (inputData == null)
            {
                throw new ArgumentNullException("Null not allowed");
            }
            Value = inputData;
            _childNodes = new List<TreeNode<T>>();
        }
      
        public T Value { get; set; }

        public int ChildrenCount => _childNodes.Count;

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException("Null not allowed");
            }
            if (child.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }
            child.hasParent = true;
            _childNodes.Add(child);
        }
        
        public TreeNode<T> GetChild(int index)
        {
            return _childNodes[index];
        }
    }
}