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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = CreateGraphics();
            Font drawFont = new Font("Segoe Print", 40);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            graph.DrawString("БАЛДА", drawFont, drawBrush, 135, 100);
        }
    }
}
