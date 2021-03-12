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
    }
}
