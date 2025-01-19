using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Huffman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Tree_Click(object sender, EventArgs e)
        {
            List<Node> countedList = createCountedList(InputText.Text);
            
            
            Type type = typeof(NodeS);      
            while(countedList.Count > 1)
            {
                treeView1.Nodes.Clear();
                Node first= countedList.First();
                countedList.Remove(first);
                Node second= countedList.First();
                countedList.Remove(second);
                Node node = new Node(first.data+second.data,first,second);
                first.parent = node;
                second.parent = node;
                countedList.Add(node);
                countedList= countedList.OrderBy(c => c.data).ToList();              
                TreeNode rootNode = new TreeNode(countedList.First().data.ToString());
                convertTreeToTreeView(countedList.First(), rootNode);
                treeView1.Nodes.Add(rootNode);
                treeView1.ExpandAll();
                List<String> list = new();
                Form1Helpers.GenerateCodes(node, list);
                String codes = "";
                foreach(String s in list )
                {
                    codes+= s+"\n";
                }
                label2.Text = codes;
            }
            
            

        }
        
        private void convertTreeToTreeView(Node node, TreeNode treeNode)
        {
           
            
            {
                if (node.right != null)
                {
                    
                    if(node.right.GetType() == typeof(NodeS))
                    {
                        NodeS node2 = (NodeS)node.right;
                        TreeNode nodeS = new TreeNode(node2.symbol.ToString());
                        treeNode.Nodes.Add(nodeS);
                        
                    }
                    else
                    {
                        TreeNode right;
                        right = new TreeNode(node.right.data.ToString());
                        treeNode.Nodes.Add(right);
                        convertTreeToTreeView(node.right, right);
                    }
                    
                }

                if (node.left != null)
                {
                    if (node.left.GetType() == typeof(NodeS))
                    {
                        NodeS node2 = (NodeS)node.left;
                        TreeNode nodeS = new TreeNode(node2.symbol.ToString());
                        treeNode.Nodes.Add(nodeS);
                        
                    }
                    else
                    {
                        TreeNode left;
                        left = new TreeNode(node.left.data.ToString());
                        treeNode.Nodes.Add(left);
                        convertTreeToTreeView(node.left, left);
                    }
                    
                }
            }
            

        }
        
        List<Node> createCountedList(String s)
        {
            List<Node> list = new List<Node>();
            Boolean add = false;
            for (int i = 0; i < s.Length; i++)
            {
                foreach (NodeS node in list)
                {

                    if (node.symbol == s[i])
                    {
                        node.data++;
                        add = true;
                        break;
                    }

                }
                if (add == false)
                    list.Add(new NodeS(s[i]));
                add = false;
            }
                List<Node> a= list.OrderBy(c => c.data).ToList();

            return a;
        }
    }
}
