using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        BinarySearchTree tree = new BinarySearchTree();
        
        public Form1()
        {
            InitializeComponent();
            InputNumber.Focus();
        }

        private void AddElement_Click(object sender, EventArgs e)
        {
            if (!Equals(InputNumber.Text, ""))
            { 
                tree.Add(int.Parse(InputNumber.Text));
                UpdateTreeView();
                


            }
            InputNumber.Clear();
            InputNumber.Focus();
            


        }
        private void UpdateTreeView()
        {
            treeView1.Nodes.Clear();
            if (tree.root != null)
            {
                TreeNode rootNode = new TreeNode(tree.root.data.ToString());
                treeView1.Nodes.Add(rootNode);
                ConvertTreeToTreeView(tree.root, rootNode);
            }
            treeView1.ExpandAll();
            List<String> list = new List<String>();
            String preOrder = " ";
            String inOrder = " ";
            String postOrder = " ";
            list.Add(preOrder);
            list.Add(inOrder);
            list.Add(postOrder);
            tree.WalkingInTree(tree.root, list);
            label4.Text = list[0];
            label5.Text = list[1];
            label6.Text = list[2];
        }
        private void ConvertTreeToTreeView(NodeT node, TreeNode treeNode)
        {
            if (node.right != null)
            {
                TreeNode right = new TreeNode(node.right.data.ToString());
                treeNode.Nodes.Add(right);
                ConvertTreeToTreeView(node.right, right);
            }

            if (node.left != null)
            {
                TreeNode left = new TreeNode(node.left.data.ToString());
                treeNode.Nodes.Add(left);
                ConvertTreeToTreeView(node.left, left);
            }
        }

        private void RemoveElement_Click(object sender, EventArgs e)
        {
            if (!Equals(InputNumber.Text, ""))
            {
                tree.Remove(int.Parse(InputNumber.Text));
                UpdateTreeView();
            }
            InputNumber.Clear();
            InputNumber.Focus();
            
        }
    }
}
