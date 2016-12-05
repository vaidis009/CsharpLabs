using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
        bool negativeSign, commaSign, calculation, previuosCalculation, equalSign;
        double result = 0;
        String sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (negativeSign == false)
            {
                InputField.Text = "-" + InputField.Text;
                negativeSign = true;
            }
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (commaSign == false)
            {
                InputField.Text = InputField.Text + ".";
                commaSign = true;
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result = cal(result, double.Parse(InputField.Text), sign);
            sign = "";
            calculationField.Text = result.ToString();
            InputField.Text = "";
            equalSign = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputField.Text = InputField.Text+"9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputField.Text = "";
            calculationField.Text = "";
            negativeSign = false;
            commaSign = false;
            sign = "";
            calculation = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (equalSign == true)
            {
                calculationField.Text = calculationField.Text + "+";               
                sign = "+";
                equalSign = false;
            }
            else if (calculation==false)
            {
                result = double.Parse(InputField.Text);
                calculationField.Text = InputField.Text + "+";
                InputField.Text = "";
                calculation = true;
                sign = "+";
            }
            else
            {
                result = cal(result, double.Parse(InputField.Text), sign);
                sign = "+";
                calculationField.Text = result.ToString();
                InputField.Text = "";
            }
        }   

        private void button12_Click(object sender, EventArgs e)
        {
            if (equalSign == true)
            {
                calculationField.Text = calculationField.Text + "-";
                sign = "-";
                equalSign = false;
            }
            else if(calculation == false)
            {
                result = double.Parse(InputField.Text);
                calculationField.Text = InputField.Text + "-";
                InputField.Text = "";
                calculation = true;
                sign = "-";
            }
            else
            {
                result = cal(result, double.Parse(InputField.Text), sign);
                sign = "-";
                calculationField.Text = result.ToString();
                InputField.Text = "";
                
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            InputField.Text = "";
        }

        private void procentsBtn_Click(object sender, EventArgs e)
        {
            result = (result /100) * double.Parse(InputField.Text);
            calculationField.Text = result.ToString();
            InputField.Text = "";
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            if (equalSign == true)
            {
                calculationField.Text = calculationField.Text + "*";
                sign = "*";
                equalSign = false;
            }
            else if(calculation == false)
            {
                result = double.Parse(InputField.Text);
                calculationField.Text = InputField.Text + "*";
                InputField.Text = "";
                calculation = true;
                sign = "*";
            }
            else
            {
                result = cal(result, double.Parse(InputField.Text), sign);
                sign = "*";
                calculationField.Text = result.ToString();
                InputField.Text = "";
            }
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            if (equalSign == true)
            {
                calculationField.Text = calculationField.Text + "/";
                sign = "/";
                equalSign = false;
            }
            else if(calculation == false)
            {
                result = double.Parse(InputField.Text);
                calculationField.Text = InputField.Text + "/";
                InputField.Text = "";
                calculation = true;
                sign = "/";
            }
            else
            {
                result = cal(result, double.Parse(InputField.Text), sign);
                sign = "/";
                calculationField.Text = result.ToString();
                InputField.Text = "";
            }
        }
 
    public static double cal(double num1, double num2, string Asign)
    {
        double calResult = 0;
        if (Asign == "+")
        {
            calResult = num1 + num2;          
        }
        else if (Asign == "-")
        {
            calResult = num1 - num2;
        }
        else if(Asign == "*")
        {
            calResult = num1 * num2;
        }
        else if (Asign == "/")
        {
            calResult = num1 / num2;
        }
        else
        {
            
        }
        return calResult; 
    }   
   }
}
