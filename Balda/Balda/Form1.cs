using System;
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
        Form2 f2 = new Form2();
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
            nameplayer1.Visible = true; nameplayer1.Text = Form4.player1str;
            nameplayer2.Visible = true; nameplayer2.Text = Form4.player2str;
            player.Visible = true;
            if (play == 1) player.Text = Form4.player1str;
            else
            player.Text = Form4.player2str;
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
            //tbWORD.Visible = true;
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
           // f3.ShowDialog();
            DialogResult res = f3.ShowDialog();
            if (res == DialogResult.Yes)
            {
                beginn.Visible = true; 
            Form4 f4 = new Form4();
            f4.ShowDialog();
                //start = 2;


            }
           else this.Close();

            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            bool pr = false;//
            Graphics graph = CreateGraphics();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (input == true)
                    {
                        if ((currX > TOP + i * 50 && currY > TOP + j * 50 && currX < 175 + (i) * 50 && currY < 175 + j * 50)
                               && (doubletemp[j, i] != true))
                        {

                            if (t == 0 && check[j, i] == true)
                            {
                                if (ti == i && tj == j) round = true;
                                tbWORD.Visible = true;
                                Accept.Visible = true;
                                graph.FillRectangle(redBrush, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                                graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                                WORD += mas[j, i].ToString();
                                doubletemp[j, i] = true;
                                tbWORD.Text = WORD; t++; X = j; Y = i;
                            }
                            else
                            {
                                if ((((X - j) * (X - j) < 2 && (Y - i) * (Y - i) == 0) || ((X - j) * (X - j) == 0 && (Y - i) * (Y - i) < 2)) && check[j, i] == true)
                                {
                                    if (ti == i && tj == j) round = true;
                                    graph.FillRectangle(redBrush, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                                    graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                                    WORD += mas[j, i].ToString();
                                    doubletemp[j, i] = true;
                                    tbWORD.Text = WORD; t++; X = j; Y = i;
                                }
                            }

                        }
                    }
                    else
                    {
                        inpWORD.Visible = true;
                        if (check[j, i] == false &&
                            (check1[j + 2, i + 1] == true || check1[j, i + 1] == true || check1[j + 1, i] == true || check1[j + 1, i + 2] == true))
                        {
                            if (currX > TOP + i * 50 && currY > TOP + j * 50 && currX < 175 + (i) * 50 && currY < 175 + j * 50)
                            {
                                graph.FillRectangle(yellowBrush, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                                f2.ShowDialog();
                                if (Form2.str.Length == 0)
                                {
                                    graph.FillRectangle(white, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                                }
                                else
                                {
                                    back.Visible = true;
                                    //Form2.;
                                    ti = i;
                                    tj = j;
                                    pr = true;
                                    ////////////////////////////////////////////////
                                    {

                                        TEMP = Form2.str;
                                        Form2.str = "";
                                        mas[tj, ti] = TEMP[0];
                                        check[tj, ti] = true; check1[tj + 1, ti + 1] = true;
                                        //textBox1.Visible = false;
                                        //button1.Visible = false;
                                        graph.FillRectangle(white, TOP + 3 + ti * 50, TOP + 3 + tj * 50, 45, 45);
                                        graph.DrawString(mas[tj, ti].ToString(), drawFont, drawBrush, TOP + 50 * ti + 15, TOP + 50 * tj + 15);
                                        input = true;
                                        inpWORD.Visible = false;
                                        inputt.Visible = true;

                                    }
                                }
                            }
                            if (pr == true) break;

                        }
                    }
                 if (pr == true) { pr = false; break; }
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currX = e.X;
            currY = e.Y;
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Graphics graph = CreateGraphics();
            back.Visible = false;
            bool pr = false;
            bool pr1 = false;
            string s;
            if (round == false)
            {
                MessageBox.Show("Слово должно содержать введенную букву!");
                //MessageBox.Show("Такое слово уже есть!!!");
                ///////////////////////////
                mas[tj, ti] = ' ';
                check[tj, ti] = false; check1[tj + 1, ti + 1] = false;
                WORD = "";
                t = 0;
                doubletemp[tj, ti] = false;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        graph.FillRectangle(white, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                        graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                        doubletemp[j, i] = false;
                    }
                }
                input = false;
                inpWORD.Visible = true;
                inputt.Visible = false;
                tbWORD.Text = "";
                Accept.Visible = false;
                tbWORD.Visible = false;
            }
            else
            {
                round = false;
                for (int k = 0; k < checkword.Length; k++)
                    if (checkword[k] == WORD)
                        pr1 = true;
                if (pr1)
                {
                    MessageBox.Show("Такое слово уже есть!");
                    ///////////////////////////
                    mas[tj, ti] = ' ';
                    check[tj, ti] = false; check1[tj + 1, ti + 1] = false;
                    WORD = "";
                    t = 0;
                    doubletemp[tj, ti] = false;
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            graph.FillRectangle(white, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                            graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                            doubletemp[j, i] = false;
                        }
                    }
                    input = false;
                    inpWORD.Visible = true;
                    inputt.Visible = false;
                    tbWORD.Text = "";
                    Accept.Visible = false;
                    tbWORD.Visible = false;
                    ////////////////////////////
                }
                else
                {



                    StreamReader f = new StreamReader("lib.RUS", Encoding.GetEncoding(1251)); //Создаем поток и связываем его с конкретным файлом
                    while ((s = f.ReadLine()) != null)//пока не конец потока
                    {
                        if (s == WORD) pr = true;

                    }
                    if (pr)
                    {
                        checkword[checkwordt++] = WORD;
                        Array.Resize(ref checkword, checkwordt + 1);
                        wordinp(graph);
                    }

                    else
                    {
                        DialogResult res = MessageBox.Show("Нет такого слова!\nПодтвердить введенное слово?", "", MessageBoxButtons.YesNo);
                        if (res == DialogResult.No)
                        {

                            mas[tj, ti] = ' ';
                            check[tj, ti] = false; check1[tj + 1, ti + 1] = false;
                            WORD = "";
                            t = 0;
                            doubletemp[tj, ti] = false;
                            for (int i = 0; i < 5; i++)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    graph.FillRectangle(white, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                                    graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                                    doubletemp[j, i] = false;
                                }
                            }
                            input = false;
                            inpWORD.Visible = true;
                            inputt.Visible = false;
                            tbWORD.Text = "";
                            Accept.Visible = false;
                            tbWORD.Visible = false;
                        }
                        else
                        {
                            checkword[checkwordt++] = WORD;
                            Array.Resize(ref checkword, checkwordt + 1);
                            wordinp(graph);
                        }
                    }
                }
                bool profend = true;
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                    {
                       
                        if (check[j, i] == false)
                            profend = false;
                    }
                if (profend)
                {
                    if (player1score > player2score)
                        MessageBox.Show("Выиграл игрок " + Form4.player1str + "!!!");
                    if (player1score < player2score)
                        MessageBox.Show("Выиграл игрок " + Form4.player2str + "!!!");
                    if (player1score == player2score)
                        MessageBox.Show("Ничья!!!");
                }
            }
        }
        private void wordinp(Graphics graph)
        {
            t = 0;
            if (play == 1)
            {
                player1score += WORD.Length;
                player1lb.Items.Add(WORD);
                Score1.Text = "Очки = " + player1score.ToString();
                play = 2;
            }
            else
            {
                player2score += WORD.Length;
                Score2.Text = "Очки = " + player2score.ToString();
                player2lb.Items.Add(WORD);
                play = 1;
            }
            WORD = "";
            ////////////////////////////////////////////
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    graph.FillRectangle(white, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                    graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                    doubletemp[j, i] = false;
                }
            }
            ///////////////////////////////////////////
            input = false;
            inputt.Visible = false;
            tbWORD.Text = "";
            Accept.Visible = false;
            tbWORD.Visible = false;
            inpWORD.Visible = true;
            if (play == 1) player.Text = Form4.player1str;
            else
                player.Text = Form4.player2str;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Graphics graph = CreateGraphics();
            mas[tj, ti] = ' ';
            check[tj, ti] = false; check1[tj + 1, ti + 1] = false;
            WORD = "";
            t = 0;
            doubletemp[tj, ti] = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    graph.FillRectangle(white, TOP + 3 + i * 50, TOP + 3 + j * 50, 45, 45);
                    graph.DrawString(mas[j, i].ToString(), drawFont, drawBrush, TOP + 50 * i + 15, TOP + 50 * j + 15);
                    doubletemp[j, i] = false;
                }
            }
            input = false;
            inpWORD.Visible = true;
            inputt.Visible = false;
            tbWORD.Text = "";
            Accept.Visible = false;
            tbWORD.Visible = false;
        }
        
    }
}
