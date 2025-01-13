namespace Podciagi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String podciag="";
            //String a = "";
            String s1 = " "+textBox1.Text;
            String s2 = " "+textBox2.Text;
            int[,] tab = new int[s1.Length, s2.Length];
            int i = 1;
            int j = 1;
            for (;i<tab.GetLength(0); i++)
            {
                for (; j < tab.GetLength(1); j++)
                {
                    if (s1[i] == s2[j])
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    else
                    {
                        if (tab[i - 1, j] >= tab[i, j - 1])
                            tab[i, j] = tab[i - 1, j];
                        else
                            tab[i, j] = tab[i,j-1];
                    }
                    //a += " "+tab[i, j]+" ";
                }
                //a += "\n";
            }
            //label1.Text = a;
            i = tab.GetLength(0)-1;
            j = tab.GetLength(1)-1;
            while (i > 0 && j>0)
            {
                if (i > 0 && tab[i, j] == tab[i - 1, j])
                {
                    i--;
                    
                }
                if (j > 0 && tab[i, j] == tab[i, j-1])
                {
                    
                    j--;
                }
                if (i > 0 && j>0 && tab[i, j] -1== tab[i - 1, j-1])
                {
                    podciag = s1[i] + podciag;
                    i--;
                    j--;
                }

            }
            label1.Text = podciag;
            
            
        }
    }
}