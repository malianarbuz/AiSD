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
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graf1 g1 = new Graf1();
            NodeG1 n0 = new NodeG1(0);
            NodeG1 n1 = new NodeG1(1);
            NodeG1 n2 = new NodeG1(2);
            NodeG1 n3 = new NodeG1(3);
            NodeG1 n4 = new NodeG1(4);
            NodeG1 n5 = new NodeG1(5);
            NodeG1 n6 = new NodeG1(6);
            NodeG1 n7 = new NodeG1(7);
            g1.Add(new Edge(n0, n1, 5));
            g1.Add(new Edge(n1, n2, 9));
            g1.Add(new Edge(n0, n3, 9));
            g1.Add(new Edge(n1, n4, 8));
            g1.Add(new Edge(n1, n5, 6));
            g1.Add(new Edge(n0, n6, 3));
            g1.Add(new Edge(n2, n3, 9));
            g1.Add(new Edge(n3, n6, 8));
            g1.Add(new Edge(n2, n4, 4));
            g1.Add(new Edge(n4, n5, 2));
            g1.Add(new Edge(n4, n6, 1));
            g1.Add(new Edge(n5, n6, 6));
            g1.Add(new Edge(n2, n6, 5));
            g1.Add(new Edge(n1, n7, 7));
            g1.Add(new Edge(n2, n7, 3));
            g1.Add(new Edge(n6, n7, 9));
            Graf1 rozp = g1.DrzewoRozpinajace();
            String rozpT="";
            for (int i = 0; i < rozp.edges.Count(); i++)
            {
                rozpT+=( rozp.edges[i].start.data.ToString() + " " + rozp.edges[i].end.data.ToString() + " " + rozp.edges[i].weight+"\n");
            }
            label1.Text = rozpT;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
