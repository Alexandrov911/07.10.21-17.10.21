using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07._10._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int n = Convert.ToInt32(numericUpDown1.Value);
            int[] mas = new int[n];
            Random r = new Random();
            for(int i=0; i<n; i++)
            {
                mas[i] = r.Next(0,100);
                textBox1.Text = textBox1.Text + mas[i] + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = textBox1.Lines.Count();
            int[] mas = new int[n];
            for(int i=0; i<n; i++)
            {
                mas[i] = Convert.ToInt32(textBox1.Lines[i]);
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + mas[i];
            }
            MessageBox.Show(sum.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns.Clear();
            int n = Convert.ToInt32(numericUpDown1.Value);
            int[] mas = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(0, 100);
                dataGridView1[i, 0].Value = mas[i].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.ColumnCount;
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(dataGridView1[i,0].Value);
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + mas[i];
            }
            MessageBox.Show(sum.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
