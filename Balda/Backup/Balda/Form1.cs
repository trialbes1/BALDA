﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Balda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public int currX;
        static public int currY;
        int start = 1;
        bool round = false;
        int play = 1;
        int t = 0;
        const int TOP = 125;
        int checkwordt = 0;
        static public string TEMP, WORD = "";
        static public int ti, tj, X, Y;
        static public char[,] mas = new char[5, 5];
        static public bool[,] check = new bool[5, 5];
        static public bool[,] check1 = new bool[7, 7];
        static public bool[,] doubletemp = new bool[5, 5];
        static public string[] checkword = new string[1];
        static public bool input = false;
        static public int player1score = 0, player2score = 0;
        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        // public Graphics *graph = CreateGraphics();
        static public SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        static public SolidBrush redBrush = new SolidBrush(Color.Red);
        static public Font drawFont = new Font("Arial", 15);
        static public SolidBrush drawBrush = new SolidBrush(Color.Black);
        static public SolidBrush white = new SolidBrush(Color.White);
        private void beginn_Click(object sender, EventArgs e)
        {
            player1lb.Visible = true;
            player2lb.Visible = true;
            //nameplayer1.Visible = true; nameplayer1.Text = Form4.player1str;
            //nameplayer2.Visible = true; nameplayer2.Text = Form4.player2str;
            player.Visible = true;
            //if (play == 1) player.Text = Form4.player1str;
            //else
            //    player.Text = Form4.player2str;
            Score1.Visible = true;
            Score2.Visible = true;
            int i = 0;
            string[] str = new string[1];
            string s;
            StreamReader f = new StreamReader("lib.RUS", Encoding.GetEncoding(1251)); //Создаем поток и связываем его с конкретным файлом
            while ((s = f.ReadLine()) != null)//пока не конец потока
            {
                if (s.Length == 5)
                {
                    Array.Resize(ref str, ++i);
                    str[i - 1] = s;

                }

            }
            f.Close();
            Random x = new Random();
            int n = x.Next(i - 1);
            checkword[checkwordt++] = str[n];
            Array.Resize(ref checkword, checkwordt + 1);
            mas[2, 0] = str[n][0]; check[2, 0] = true; check1[3, 1] = true;
            mas[2, 1] = str[n][1]; check[2, 1] = true; check1[3, 2] = true;
            mas[2, 2] = str[n][2]; check[2, 2] = true; check1[3, 3] = true;
            mas[2, 3] = str[n][3]; check[2, 3] = true; check1[3, 4] = true;
            mas[2, 4] = str[n][4]; check[2, 4] = true; check1[3, 5] = true;
            New();
            beginn.Visible = false;
            inpWORD.Visible = true;
        }
        private void New()
        {
            tbWORD.Visible = true;
            Graphics graph = CreateGraphics();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    graph.DrawRectangle(new Pen(Brushes.Black, 3), TOP + 50 * i, TOP + 50 * j, 50, 50);
                    graph.FillRectangle(white, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                    graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                }

        }

        private void Exitbbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            //f3.ShowDialog();
            DialogResult res = f3.ShowDialog();
            if (res == DialogResult.Yes)
            {
                //Form4 f4 = new Form4();
               // f4.ShowDialog();

                beginn.Visible = true;
                //start = 2;


            }
            else this.Close();
        }
    }
}
