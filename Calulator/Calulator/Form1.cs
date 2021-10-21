﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calulator
{
    public partial class Form1 : Form
    {
        string input = "";     //string storing user input
        string first = "";     //string storing first input 
        string secound = "";   //string storing secound input
        char function;         //char to store type of function
        double result = 0.0;   //To hold the result
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "1";
            resultOutput.Text += input; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "2";
            resultOutput.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "3";
            resultOutput.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "4";
            resultOutput.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "5";
            resultOutput.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "6";
            resultOutput.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "7";
            resultOutput.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "8";
            resultOutput.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "9";
            resultOutput.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "";
            input += "0";
            resultOutput.Text += input;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            input += ".";
        }


        private void additionButton_Click(object sender, EventArgs e)
        {
            first = input;
            function = '+';
            input = "";
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            first = input;
            function = '-';
            input = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            first = input;
            function = '*';
            input = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            first = input;
            function = '/';
            input = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            secound = "";
            input = "";
            resultOutput.Text = "0";

        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            secound = input;
            double num1, num2;
            double.TryParse(first, out num1);
            double.TryParse(secound, out num2);


            //addition
            if (function == '+')
            {
                result = num1 + num2;
                resultOutput.Text = result.ToString();
            }
            //subtract
            else if (function == '-')
            {
                result = num1 - num2;
                resultOutput.Text = result.ToString();
            }
            //multiply
            else if (function == '*')
            {
                result = num1 * num2;
                resultOutput.Text = result.ToString();
            }
            //division
            else if (function == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    resultOutput.Text = result.ToString();
                }
                else
                {
                    resultOutput.Text = "Error";
                }
            }

        }
    }
}