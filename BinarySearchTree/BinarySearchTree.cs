using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        public NodeT root;

        public void Add(int number)
        {
            var child=new NodeT(number);
            if(this.root == null)
            {
                this.root = child;
                return;
            }
            var parent=this.SearchParent(child);
            child.parent = parent;
            if( parent.data > child.data)
                parent.left = child;
            else
                parent.right = child;

        }
        public void Remove(int number)
        {
            if(this.root == null)
                return;
            NodeT tmp=this.FindElement(number);  
            if (tmp == null)
                return;
           // if (tmp == this.root)
            {
            //    this.root = null;
            //    return;
            } 
            if (tmp.left ==null && tmp.right ==null)
            {
                if(tmp.parent.data >number)
                    tmp.parent.left = null;
                else
                    tmp.parent.right = null;
                
                tmp.parent = null;
                return;
            }
            if (tmp.left != null && tmp.right != null)
            {
                var temp = tmp.left;
                while(temp.right!=null)
                {
                    temp= temp.right;
                }
                tmp.data = temp.data;
                temp.parent.right = null;
                //temp.parent = null;
                return;
            }
            if (tmp.right == null )
            {
                var temp = tmp.parent;
                temp.left = tmp.left;
                tmp.left.parent= temp;
                tmp.left = null;
                tmp.parent = null;

            }
            else
            {
                var temp = tmp.parent;
                temp.right = tmp.right;
                tmp.right.parent = temp;
                tmp.right = null;
                tmp.parent = null;
            }
        }
        public NodeT SearchParent(NodeT child)
        {
            var tmp = this.root;
            while(true)
            {
                if(tmp.data > child.data)
                {
                    if (tmp.left == null)
                        return tmp;
                    else
                        tmp = tmp.left;
                }
                else
                {
                    if(tmp.right == null)
                        return tmp;
                    else
                        tmp = tmp.right;
                }
            }
        }
        public void WalkingInTree(NodeT element)
        {
            if (element == null)
                return;
            
            this.WalkingInTree(element.left);
            this.WalkingInTree(element.right);

        }
        public NodeT FindElement(int number)
        {
            var tmp=this.root;
            while(tmp.data != number)
            {
                if ((tmp.left == null) && (tmp.right == null))
                    return null;
                if(number < tmp.data)
                    tmp = tmp.left;
                else
                    tmp=tmp.right;
            }
            return tmp;
        }
        
    }
}
