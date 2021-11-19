using System;
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
        double s;

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
            resultOutput.Text = "0";
            input = "";
            first = "";
            secound = "";
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
                input = result.ToString();
                resultOutput.Text = result.ToString();
            }
            //subtract
            else if (function == '-')
            {
                result = num1 - num2;
                input = result.ToString();
                resultOutput.Text = result.ToString();
            }
            //multiply
            else if (function == '*')
            {
                result = num1 * num2;
                input = result.ToString();
                resultOutput.Text = result.ToString();
            }
            //division
            else if (function == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    input = result.ToString();
                    resultOutput.Text = result.ToString();
                }
                else
                {
                    resultOutput.Text = "Error";
                }
            }

        }

        private void backSpace_Click(object sender, EventArgs e)
            //Back Space Button
        {
            int index = resultOutput.Text.Length;
            index--;
            resultOutput.Text = resultOutput.Text.Remove(index);
           if (resultOutput.Text == "")
            {
                resultOutput.Text = "0";
            }
        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            resultOutput.Text = "0";

            string f, s;
            f = Convert.ToString(first);
            s = Convert.ToString(secound);

            f = "";
            s = "";
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            s = Convert.ToDouble(resultOutput.Text) / Convert.ToDouble(100);
            resultOutput.Text = System.Convert.ToString(s);
        }

        private void squaredButton_Click(object sender, EventArgs e)
        {
            result = double.Parse(resultOutput.Text);
            result = Math.Sqrt(result);
            resultOutput.Text = result.ToString();


        }

        private void button15_Click(object sender, EventArgs e)
        {
            s = Convert.ToDouble(resultOutput.Text) * Convert.ToDouble(100);
            resultOutput.Text = System.Convert.ToString(s);
        }

        private void button16_Click(object sender, EventArgs e)
        {

            result = double.Parse(resultOutput.Text);
            result = 1 / result;
            resultOutput.Text = result.ToString();
        }

        private void PMbutton_Click(object sender, EventArgs e)
        {
            result = double.Parse(resultOutput.Text);
            result = result * -1;
            resultOutput.Text = result.ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) 
        {
            if (e.Node.Name == "Node2")
            {
                Title.Text = "Standard";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node23") 
            {
                Title.Text = "Scientific";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node25") 
            {
                Title.Text = "Programmer";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node27") 
            {
                Title.Text = "Data Calculation";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node31")
            {
                Title.Text = "Currency";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node33") 
            {
                Title.Text = "Volume";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node35") 
            {
                Title.Text = "Length";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node37") 
            {
                Title.Text = "Weight and Mass";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node39") 
            {
                Title.Text = "Temperature";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node41") 
            {
                Title.Text = "Energy";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node43") 
            {
                Title.Text = "Area";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node45") 
            {
                Title.Text = "Speed";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node47") 
            {
                Title.Text = "Time";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node49") 
            {
                Title.Text = "Power";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node51") 
            {
                Title.Text = "Data";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node53") 
            {
                Title.Text = "Pressure";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node55") 
            {
                Title.Text = "Angle";
                treeView1.Visible = false;
            }
            if (e.Node.Name == "Node57") 
            {
                Title.Text = "About";
                treeView1.Visible = false;
            }

        }

        private void offButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            result = double.Parse(resultOutput.Text);
            result = Math.Log10(result);
            resultOutput.Text = result.ToString();
        }

        private void expButton_Click(object sender, EventArgs e)
        {
            result = double.Parse(resultOutput.Text);
            result = Math.Exp(result);
            resultOutput.Text = result.ToString();
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            resultOutput.Text = result.ToString();
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(first, out num1);
            result = double.Parse(resultOutput.Text);
            result = (num1 % double.Parse(resultOutput.Text));
            resultOutput.Text = result.ToString();
        }

        private void cubeButton_Click(object sender, EventArgs e)
        {
            result = double.Parse(resultOutput.Text);
            result = Math.Pow(result, 3);
            resultOutput.Text = result.ToString();
        }
    }
}
