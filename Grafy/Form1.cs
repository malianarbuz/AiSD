using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafy
{
    public partial class Form1 : Form
    {
        Graf1 g1 = new Graf1();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf1 rozp = g1.DrzewoRozpinajace();
            label4.Text = "\n" + rozp.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NodeG1 start = g1.GetNode(0);
            if (start != null)
            {
                String s = "\n";
                List<Edge> list = g1.DijkstryAlgorithm(start);
                foreach(Edge n in list)
                {
                    s += "Od " + n.start + "do " + n.end + " droga wynosi " + n.weight+"\n";
                }
                label5.Text = s;
            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            g1.AddEdge(new Edge(new NodeG1((int)numericUpDown1.Value), new NodeG1((int)numericUpDown2.Value),(int) numericUpDown3.Value));
            label1.Text = "\n" + g1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NodeG1 n0 = new NodeG1(0);
            NodeG1 n1 = new NodeG1(1);
            NodeG1 n2 = new NodeG1(2);
            NodeG1 n3 = new NodeG1(3);
            NodeG1 n4 = new NodeG1(4);
            NodeG1 n5 = new NodeG1(5);
            NodeG1 n6 = new NodeG1(6);
            NodeG1 n7 = new NodeG1(7);
            g1.AddEdge(new Edge(n0, n1, 5));
            g1.AddEdge(new Edge(n1, n2, 9));
            g1.AddEdge(new Edge(n0, n3, 9));
            g1.AddEdge(new Edge(n1, n4, 8));
            g1.AddEdge(new Edge(n1, n5, 6));
            g1.AddEdge(new Edge(n0, n6, 3));
            g1.AddEdge(new Edge(n2, n3, 9));
            g1.AddEdge(new Edge(n3, n6, 8));
            g1.AddEdge(new Edge(n2, n4, 4));
            g1.AddEdge(new Edge(n4, n5, 2));
            g1.AddEdge(new Edge(n4, n6, 1));
            g1.AddEdge(new Edge(n5, n6, 6));
            g1.AddEdge(new Edge(n2, n6, 5));
            g1.AddEdge(new Edge(n1, n7, 7));
            g1.AddEdge(new Edge(n2, n7, 3));
            g1.AddEdge(new Edge(n6, n7, 9));
            label1.Text = "\n" + g1.ToString();
        }
    }
}
