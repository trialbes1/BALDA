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
    public partial class Form4 : Form

    {
        static public string player1str, player2str;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            bool pr = true;
            
                if (textBox1.Text.Length == 0)
                {
                    MessageBox.Show("Введите имя для 1го игрока");
                    pr = false; 
                }
                else
                    player1str = textBox1.Text;
                if (textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Введите имя для 2го игрока");
                    pr = false;
                }
                else
                    player2str = textBox2.Text;
                if (textBox1.Text == textBox2.Text) {
                    MessageBox.Show("Имена совпадают!Введите различные имена!"); pr = false;
                }
            if (pr)
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(textBox1.Text.Length < 10))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(textBox2.Text.Length < 10))
            {
                if (e.KeyChar != (char)Keys.Back) e.Handled = true;
            }
        }
    }
}
