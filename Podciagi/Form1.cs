using System.Data;
using System.Windows.Forms.VisualStyles;

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
            String podciag = "";
            //String a = "";
            String s1 = " " + textBox1.Text;
            String s2 = " " + textBox2.Text;
            int[,] tab = new int[s1.Length, s2.Length];
            
            
            for (int i = 1; i < tab.GetLength(0); i++)
            {
                for (int j = 1; j < tab.GetLength(1); j++)
                {
                    if (s1[i] == s2[j])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);

                    }

                }

            }
            
            DataTable dt = ConvertArrayToDataTable(tab);
            
            dataGridView1.DataSource = dt;
            


            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Width = 30; 
                dataGridView1.Columns[i].HeaderText = s2[i].ToString();
            }

            for(int i = 0; i<dataGridView1.Rows.Count-1; i++)
            {
                dataGridView1.Rows[i].Height = 30;
                dataGridView1.Rows[i].HeaderCell.Value = s1[i].ToString();
            }

            int k = tab.GetLength(0)-1;
            int l = tab.GetLength(1)-1;
            while (k > 0 && l>0)
            {
                
                if (k > 0 && tab[k, l] == tab[k - 1, l])
                {
                    dataGridView1[l, k].Style.BackColor = Color.Pink;
                    k--;
                    
                }
                else if (l > 0 && tab[k, l] == tab[k, l-1])
                {
                    dataGridView1[l, k].Style.BackColor = Color.Pink;
                    l--;
                }
                else if (k > 0 && l>0 && tab[k, l] -1== tab[k - 1, l-1])
                {
                    dataGridView1[l,k].Style.BackColor = Color.Red;
                    podciag = s1[k] + podciag;
                    k--;
                    l--;
                }

            }
            label1.Text = podciag;
            
            
        }
        static DataTable ConvertArrayToDataTable(int[,] array)
        {
            DataTable dataTable = new DataTable();
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int col = 0; col < cols; col++)
            {
                dataTable.Columns.Add($"Column{col + 1}", typeof(int));
            }
            for (int row = 0; row < rows; row++)
            {
                DataRow newRow = dataTable.NewRow();
                for (int col = 0; col < cols; col++)
                {
                    newRow[col] = array[row, col];
                }
                dataTable.Rows.Add(newRow);
            }

            return dataTable;
        }
    }
}