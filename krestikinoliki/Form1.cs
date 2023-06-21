using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krestikinoliki
{
    public partial class Form1 : Form
    {
        int Oturn;     
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "O")
            {
                button1.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
            }
            //win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Youre win");
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Youre win");
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Youre win");
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Youre win");
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Youre win");
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Youre win");
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Youre win");
            }
            else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Youre win");
            }

            //lose
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Youre lose");
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Youre lose");
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Youre lose");
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Youre lose");
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Youre lose");
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Youre lose");
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Youre lose");
            }
            else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Youre lose");





            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text != "O")
            {
                button3.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text != "O")
            {
                button2.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text != "O")
            {
                button4.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }
    
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text != "O")
            {
                button5.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text != "O")
            {
                button6.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text != "O")
            {
                button7.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "O")
            {
                button8.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text != "O")
            {
                button9.Text = "X";
            }

            bool Otry = false;

            while (Otry == false)
            {
                Random random = new Random();
                Oturn = random.Next(1, 10);
                if (Oturn == 1 && button1.Text == "1")
                {
                    button1.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 2 && button2.Text == "2" && Otry == false)
                {
                    button2.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 3 && button3.Text == "3" && Otry == false)
                {
                    button3.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 4 && button4.Text == "4" && Otry == false)
                {
                    button4.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 5 && button5.Text == "5" && Otry == false)
                {
                    button5.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 6 && button6.Text == "6" && Otry == false)
                {
                    button6.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 7 && button7.Text == "7" && Otry == false)
                {
                    button7.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 8 && button8.Text == "8" && Otry == false)
                {
                    button8.Text = "O";
                    Otry = true;

                }
                else if (Oturn == 9 && button9.Text == "9" && Otry == false)
                {
                    button9.Text = "O";
                    Otry = true;

                }
                //win
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }
                else if (button7.Text == "X" && button5.Text == "X" && button3.Text == "X")
                {
                    MessageBox.Show("Youre win");
                }

                //lose
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
                else if (button7.Text == "O" && button5.Text == "O" && button3.Text == "O")
                {
                    MessageBox.Show("Youre lose");
                }
            }
        }
    }
}
