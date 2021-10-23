using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._10._21
{
    public partial class Form1 : Form
    {
        int[,] mas;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown1.Value);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown2.Value);
            dataGridView3.ColumnCount = Convert.ToInt32(numericUpDown2.Value);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 1;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 1;
            dataGridView3.RowCount = 1;
            dataGridView3.ColumnCount = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount;
            int m = dataGridView1.ColumnCount;
            mas = new int[m, n];
            Random r = new Random();
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    mas[i, j] = r.Next(1, 30);
                    dataGridView1[i, j].Value = mas[i, j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(numericUpDown1.Value);
            int n = dataGridView1.RowCount;
            int m = dataGridView1.ColumnCount;
            double[] mas2 = new double[k];
            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                for(int j = 0; j < m; j++)
                {
                    sum += mas[j, i];
                }
                mas2[i] = sum*1.0/m;
                dataGridView2[0, i].Value = mas2[i].ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount;
            int m = dataGridView1.ColumnCount;
            int[] mas_min = new int[n];
            for(int i=0; i<m; i++)
            {
                int min = mas[i, 0];
                for (int j=0; j < n; j++)
                {
                    if (mas[i, j] < min)
                    {
                        min = mas[i, j];
                    }
                }
                mas_min[i] = min;
                dataGridView3[i, 0].Value = mas_min[i];
            }
        }
    }
}
