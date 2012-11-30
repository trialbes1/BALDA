using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Balda
{
    public partial class Form2 : Form
    {
        static public string str = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0)
                MessageBox.Show("Введите заглавную русскую букву!");
            else
            {
                str = textBox1.Text;
                textBox1.Text = "";
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 1040 && e.KeyChar <= 1071) || !(textBox1.Text.Length < 1))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }
    }
}
