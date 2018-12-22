using System;
using System.Collections.Generic;

namespace Aufgabe10
{
    class Tree
    {


        static void Main(string[] args)
        {


        }
 
        public void CreateNode(string CreateNode)
        {
            Console.WriteLine("Wer soll zur Liste (root) hinzugefügt werden?");
            string createNodePerson = Console.ReadLine();

            TreeNode<string> tree = new TreeNode<string>();
        }

        public void AppendChild(string child1)
        {
            Console.WriteLine("Wer soll zur Liste (child) hinzugefügt werden");
            string appendPerson = Console.ReadLine();

            //TreeNode<string> parts = new TreeNode<string>();
            //parts.Add(new TreeNode<string>(){appendPerson});

            IList<string> intList = new List<string>();
            intList.Add(appendPerson);
        }

        public void RemoveNode()
        {
            Console.WriteLine("Welche Person soll entfernt werden?");
            string removePerson = Console.ReadLine();






        }
        
    }
}
