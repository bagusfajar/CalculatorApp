using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }
        private int Perkalian(int a, int b)
        {
            return a * b;
        }
        private int Pembagian(int a, int b)
        {
            return a / b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("{2}", a, b, Penambahan(a, b)));
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("{2}", a, b, Pengurangan(a, b)));
            }
            if (comboBox1.SelectedIndex == 2)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("{2}", a, b, Perkalian(a, b)));
            }
            if (comboBox1.SelectedIndex == 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(string.Format("{2}", a, b, Pembagian(a, b)));
            }
        }
    }
}
