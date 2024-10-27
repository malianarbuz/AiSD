using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ListyKierunkowe
{
    public partial class Form1 : Form
    {
        internal List a = new ListyKierunkowe.List();





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int element;
            if (!InputElement.Text.Equals(""))
            {
                
                try
                {
                    element = int.Parse(InputElement.Text);
                    a.AddLast(element);
                    InputElement.Clear();
                    label1.Text = a.ConvertToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wartość musi byc liczba i  być mniejsza niż 2^31");
                }  
                
            }     
            InputElement.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int element;
            if (!InputElement.Text.Equals(""))
            {
                try
                {
                    element = int.Parse(InputElement.Text);
                    a.AddFirst(element);
                    InputElement.Clear();
                    label1.Text = a.ConvertToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Wartość musi byc liczba i  być mniejsza niż 2^31");
                }

            }
            InputElement.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.RemoveLast();
            label1.Text = a.ConvertToString();
            InputElement.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a.RemoveFirst();
            label1.Text = a.ConvertToString();
            InputElement.Focus();
        }
    }
}
