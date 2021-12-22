using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "1";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "2";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "3";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "4";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "5";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "6";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "7";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "8";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            //jika textboxnya adalah nilai 0 dan bkn kosong 
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";//replace dgn nilai 1
            }
            else//jika tdk
            {
                textBox1.Text = textBox1.Text + "9";//menambah nilai 1 dikanan nilai sblmnya
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bad_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void bc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void broot_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "√";
        }

        private void brank_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "^";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
            else if (Operation == "√")
            {
                Result = Math.Sqrt(FirstNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "^")
            {
                Result = Math.Pow(FirstNumber, SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
        }
    }
}

