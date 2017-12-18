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
        double result = 0; // holds the first numbers entered before pressing the operation
        string operation = "";
        bool operationPressed = false; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Zero_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }

            operationPressed = false;
            txtBox_Result.Text += "0";
        }

        private void btn_One_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "1";
        }

        private void btn_Two_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "2";
        }

        private void btn_Three_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "3";
        }

        private void btn_Four_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "4";
        }

        private void btn_Five_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "5";
        }

        private void btn_Six_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "6";
        }

        private void btn_Seven_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "7";
        }

        private void btn_Eight_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            
            operationPressed = false;
            txtBox_Result.Text += "8";
        }

        private void btn_Nine_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }

            operationPressed = false;
            txtBox_Result.Text += "9";
        }

        private void btn_Decimal_Click(object sender, EventArgs e)
        {
            if ((txtBox_Result.Text == "0") || (operationPressed))
            {
                txtBox_Result.Clear();
            }
            txtBox_Result.Clear();
            operationPressed = false;
            txtBox_Result.Text += ".";
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            operation = btn_Plus.Text;
            result = double.Parse(txtBox_Result.Text);
            operationPressed = true;
            label_Current_Operation.Text = result + " " + operation;
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            operation = btn_Minus.Text;
            result = double.Parse(txtBox_Result.Text);
            operationPressed = true;
            label_Current_Operation.Text = result + " " + operation;
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            operation = btn_Multiply.Text;
            result = double.Parse(txtBox_Result.Text);
            operationPressed = true;
            label_Current_Operation.Text = result + " " + operation;
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            operation = btn_Divide.Text;
            result = double.Parse(txtBox_Result.Text);
            operationPressed = true;
            label_Current_Operation.Text = result + " " + operation;
        }

        // clears the current entry in the text box
        private void btn_ClearEntry_Click(object sender, EventArgs e)
        {
            txtBox_Result.Text = "0";
        }

        // clears the text box and resets it for new equation
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Result.Text = "0";
            result = 0;
        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {
            label_Current_Operation.Text = ""; // clear the current operation text box

            switch (operation)
            {
                case "+":
                    txtBox_Result.Text = (result + double.Parse(txtBox_Result.Text)).ToString();
                    break;
                case "-":
                    txtBox_Result.Text = (result - double.Parse(txtBox_Result.Text)).ToString();
                    break;
                case "*":
                    txtBox_Result.Text = (result * double.Parse(txtBox_Result.Text)).ToString();
                    break;
                case "/":
                    txtBox_Result.Text = (result / double.Parse(txtBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPressed = true;
        }
    }
}
