using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.Add(50);
            tree.Add(40);
            tree.Add(60);
            tree.Add(20);
            tree.Add(10);
            tree.Add(90);
            tree.Add(70);

            Console.ReadLine();
        }



    }      
}
