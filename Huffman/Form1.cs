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
            foreach (NodeS node in countedList)
            {
                s += node.symbol + " " + node.data + " ";
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
