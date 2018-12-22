using System;
namespace Aufgabe10
{
    class TreeNode<T>
    {
        public string root1;
        public string child1;
        public string child2;
        public string grandchild1;

        public void List()
        {
            TreeNode<string> root = new TreeNode<string>();
            root.root1 = "root";

            TreeNode<string> child = new TreeNode<string>();
            child.child1 = "child1";
            child.child2 = "child2";

            TreeNode<string> grandchild = new TreeNode<string>();
            grandchild.grandchild1 = "grandchild1";
        }
    }
}