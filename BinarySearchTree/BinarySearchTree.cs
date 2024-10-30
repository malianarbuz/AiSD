using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        public NodeT root;

        public void Add(int number)
        {
            if (this.root == null)
                this.root = new NodeT(number);   
            else
            {
                if(number < this.root.data)
                {
                    root.left.Add(number);
                }
                else
                {
                    root.right.Add(number);
                }
            }
        
        }
        public System.Windows.Forms.TreeView ConvertToTreeView()
        {
            NodeT temp = root;
            System.Windows.Forms.TreeView treeView= new System.Windows.Forms.TreeView();
            treeView.BeginUpdate();

            treeView.Nodes.Add(this.root.data.ToString());
            
            treeView.EndUpdate();
            return treeView;
        }
        
    }
}
