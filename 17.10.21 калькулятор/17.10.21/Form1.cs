using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._10._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Строки_Click(object sender, EventArgs e)
        {

        }

        private void Столбцы_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView3.ColumnCount= Convert.ToInt32(numericUpDown1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 1;
            dataGridView2.RowCount = 2;
            dataGridView2.ColumnCount = 1;
            dataGridView3.RowCount = 2;
            dataGridView3.ColumnCount = 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown2.Value);
            if (numericUpDown2.Value >= numericUpDown3.Value)
            {
                dataGridView3.ColumnCount = Convert.ToInt32(numericUpDown3.Value);
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown3.Value);
            if (numericUpDown3.Value >= numericUpDown2.Value)
            {
                dataGridView3.ColumnCount = Convert.ToInt32(numericUpDown2.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m1 = Convert.ToInt32(numericUpDown1.Value);
            int m2 = Convert.ToInt32(numericUpDown4.Value);
            int n1 = Convert.ToInt32(numericUpDown2.Value);
            int n2 = Convert.ToInt32(numericUpDown3.Value);
            double[,] mas1 = new double[n1, m1];
            double[,] mas2 = new double[n2, m2];
            for(int i = 0; i < n1; i++)
            {
                for(int j=0; j < m1; j++)
                {
                    mas1[i, j] = Convert.ToDouble(dataGridView1[i, j].Value);
                }
            }
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    mas2[i, j] = Convert.ToDouble(dataGridView2[i, j].Value);
                }
            }
            if (radioButton1.Checked)
            {
                if (n1 != n2)
                {
                    MessageBox.Show("Сложение матриц невозможно! Размерность не идентична!");

                }
                else
                {
                    double[,] mas3 = new double[n2, m1];
                    for (int i = 0; i < n2; i++)
                    {
                        for (int j = 0; j < m1; j++)
                        {
                            mas3[i, j] = mas1[i, j] + mas2[i, j];
                            dataGridView3[i, j].Value = mas3[i, j].ToString();
                        }
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                if (n1 != n2)
                {
                    MessageBox.Show("Вычитание матриц невозможно! Размерность не идентична!");

                }
                else
                {
                    double[,] mas3 = new double[n2, m1];
                    for (int i = 0; i < n2; i++)
                    {
                        for (int j = 0; j < m1; j++)
                        {
                            mas3[i, j] = mas1[i, j] - mas2[i, j];
                            dataGridView3[i, j].Value = mas3[i, j].ToString();
                        }
                    }
                }
            }
            else
            {
                if (n1 != m1)
                {
                    MessageBox.Show("Умножение матриц невозможно! Размерность не идентична!");
                }
                else
                {
                    dataGridView3.RowCount = dataGridView1.RowCount;
                    dataGridView3.ColumnCount = dataGridView2.ColumnCount;
                    double[,] mas3 = new double[n2, m1];


                    for (int j = 0; j < m1; j++)
                    {
                        for (int k = 0; k < n2; k++)
                        {
                            double s = 0;
                            for (int t = 0; t < m2; t++)
                            {
                                s = s + mas1[t, j] * mas2[k, t];
                            }
                            mas3[k, j] = s;
                            dataGridView3[k, j].Value = mas3[k, j].ToString();
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown4.Value);
        }
    }
}
