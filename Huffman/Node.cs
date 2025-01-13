using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Huffman
{
    internal class Node
    {
        public Node left;
        public Node right;
        public Node parent;
        public int data;

        public Node(int data,Node left,Node right)
        { 
          this.data = data; 
          this.left = left;
          this.right = right;
        }
        public Node()
        {
            this.data=0;
            
        }

    }
}

    

