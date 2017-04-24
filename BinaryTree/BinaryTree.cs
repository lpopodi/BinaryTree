using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BST
    {
        public Node root;

        public BST()
        {
            root = null;
        }

        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.value = value;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (value < current.value)
                    {
                        current = current.left;

                        if (current == null)
                            parent.left = newNode;
                        break;
                    }
                    // }
                    else
                    {
                        current = current.right;

                        if (current == null)
                            parent.right = newNode;
                        break;
                    }
                }
            }
        }  //end Add

        public void Print(Node node)
        {
            if (node == null)
                return;

        }


     } // end BST
} // end namespace
