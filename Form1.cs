using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_wpf
{
    public partial class Form1 : Form
    {
        private bool isNewOperator = true;
        private bool isComma = false;
        private string operatorType;
        private string oldNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void addNumber(object sender, EventArgs e)
        {
            if (isNewOperator) output.Text = "";
            isNewOperator = false;

            Button number = sender as Button;
            output.Text += number.Text;
        }

                private void addComma(object sender, EventArgs e)
        {
            foreach (char sign in output.Text)
            {
                if (sign == ',') isComma = true;
            }

            if (!isComma) output.Text += ",";
            isComma = true;
        }

        private void addOperator(object sender, EventArgs e)
        {
            Button op = sender as Button;

            oldNumber = output.Text;
            operatorType = op.Text;
            isNewOperator = true;
        }

        private void equalEvent(object sender, EventArgs e)
        {
            string newNumber = output.Text;
            double finalNumber = double.Parse(newNumber);

            switch(operatorType) {
                case "*":
                    finalNumber = double.Parse(oldNumber) * double.Parse(newNumber);
                    break;
                case "+":
                    finalNumber = double.Parse(oldNumber) + double.Parse(newNumber);
                    break;
                case "-":
                    finalNumber = double.Parse(oldNumber) - double.Parse(newNumber);
                    break;
                case "/":
                    finalNumber = double.Parse(oldNumber) / double.Parse(newNumber);
                    break;
            }

            output.Text = finalNumber.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            output.Text = output.Text.Remove(output.Text.Length - 1);
        }
    }
}
