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
            var child = new NodeT(number);
            if (this.root == null)
            {
                this.root = child;
                return;
            }
            var tmp = root;
            while (true)
            {
                if (child.data < tmp.data)
                {
                    if (tmp.left == null)
                    {
                        tmp.left = child;
                        child.parent = tmp;
                        break;
                    }
                    tmp = tmp.left;
                }
                else
                {
                    if (tmp.right == null)
                    {
                        tmp.right = child;
                        child.parent = tmp;
                        break;
                    }
                    tmp = tmp.right;
                }
            }

        }
        public void Remove(int number)
        {
            if (this.root == null)
                return;
            NodeT tmp = this.FindElement(number);
            if (tmp == null)
                return;
            if (tmp.left == null && tmp.right == null)
            {
                if (tmp == root)
                {
                    root = null;
                    return;
                }
                if (tmp == tmp.parent.left)
                {
                    tmp.parent.left = null;
                    tmp.parent = null;
                }
                else
                {
                    tmp.parent.right = null;
                    tmp.parent = null;
                }
                return;
            }
            else if (tmp.left == null)   
            {
                var parent = tmp.parent;
                var child = tmp.right;
                tmp.right = null;
                tmp.parent = null;
                child.parent = parent;
                if(tmp==this.root)
                {
                    this.root = child;
                    return;
                }
                if (tmp.data < parent.data)
                    parent.left = child;
                else
                    parent.right = child;

                return;
            }
            else if(tmp.right == null)
            {
                var parent= tmp.parent;
                var child = tmp.left;
                tmp.left = null;
                tmp.parent=null;
                child.parent = parent;
                if (tmp == this.root)
                {
                    this.root = child;
                    return;
                }
                if (tmp.data<parent.data)
                    parent.left = child;
                else
                    parent.right = child;
                return;
            }
            else
            {
                var temp = tmp.right;
                bool change = false;
                while(temp.left!=null)
                {
                    temp=temp.left;
                    change = true;
                }
                tmp.data = temp.data;
                if(change==true)temp.parent.left = null;
                else temp.parent.right = null;
                temp.parent = null;
            }


            
        }
        
        public void WalkingInTree(NodeT element,List<String> list)
        {
            if (element == null)
                return;
            list[0] += element.data + " ";
            this.WalkingInTree(element.left,list);
            list[1] += element.data + " ";
            this.WalkingInTree(element.right, list);
            list[2] += element.data + " ";


        }
        
        public NodeT FindElement(int number)
        {
            var tmp=this.root;  
            while(tmp!=null)
            {  
                if (tmp.data == number)
                    return tmp;
                if(number <tmp.data)
                    tmp = tmp.left;
                else
                    tmp = tmp.right;
            }
            return null;
        }
        
    }
}
