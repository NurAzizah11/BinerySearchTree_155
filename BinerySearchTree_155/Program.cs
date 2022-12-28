using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinerySearchTree_155
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        // Constructor for the Node Cllass
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /* A node class consists of three things, the information,
     * references to the right child, and references to the left child */

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

