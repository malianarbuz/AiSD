using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie
{
    internal class BinaryTree
    {
        public NodeT root;
        public void Add( List<int> list, NodeT node)
        {
            if (node == null)
            {
                try
                {
                    if(node.index == 0)
                    { }
                }
                catch (Exception)
                {

                    root = new NodeT(list[0]);
                    root.index = 0;
                    node = root;
                }
                
            }
            int leftDataIndex = 2 * node.index + 1;
            int rightDataIndex = 2 * node.index + 2;
            if(leftDataIndex<list.Count)
            {
                NodeT left=new NodeT(list[leftDataIndex]);
                left.parent = node;
                node.left = left;
                left.index = leftDataIndex;
            }
            if (rightDataIndex < list.Count)
            {
                NodeT right = new NodeT(list[rightDataIndex]);
                right.parent = node;
                node.right = right;
                right.index = rightDataIndex;
            }
            if(node.left!=null) Add( list, node.left);
            if (node.right != null) Add( list, node.right);
        }
    }
}
