using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class NodeT
    {
        public NodeT parent;
        public NodeT left;
        public NodeT right;
        public int data;
        public NodeT(int number)
        {
            this.data = number;
        } 
    }    
}
