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
        public void Add(int number)
        {
            NodeT temp = this;


            if (number < temp.data)
            {
                if (temp.left == null)
                {
                    temp.left = new NodeT(number);
                    temp.left.parent = temp;
                }
                else
                {
                    temp.left.Add(number);
                }

            }
            else
            {
                if (temp.right == null)
                {
                    temp.right = new NodeT(number);
                    temp.right.parent = temp;
                }
                else
                {
                    temp.right.Add(number);
                }
            }
        }
    }
}
