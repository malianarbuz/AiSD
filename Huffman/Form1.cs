using System.Collections.Generic;
using System.Linq;

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
            String s = "";
            
            Type type = typeof(NodeS);      
            while(countedList.Count > 1)
            {
                Node first= countedList.First();
                countedList.Remove(first);
                Node second= countedList.First();
                countedList.Remove(second);
                Node node = new Node(first.data+second.data,first,second);
                first.parent = node;
                second.parent = node;
                countedList.Add(node);
                countedList= countedList.OrderBy(c => c.data).ToList();
            }
            foreach (Node node in countedList)
            {
                s +=   " " + node.data + " ";
            }
            label1.Text = s;

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
