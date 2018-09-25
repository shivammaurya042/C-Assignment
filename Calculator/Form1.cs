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
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnThree.Click += new System.EventHandler(click);
            this.btnFour.Click += click;
            this.btnFive.Click += click;
            this.btnSix.Click += click;
            this.btnSeven.Click += click;
            this.btnEight.Click += click;
            this.btnNine.Click += click;
            this.btnOne.Click += click;
            this.btnTwo.Click += click;
            this.btnAdd.Click += operation;
            this.btnSub.Click += operation;
            this.btnMul.Click += operation;
            this.btnDiv.Click += operation;
            this.btnDecimal.Click += click;
        }
        private void click(object sender, EventArgs e)
        {
            if ((textValue.Text == "0") || (isOperationPerformed))
                textValue.Clear();

            isOperationPerformed = false;
            Button btn = sender as Button;
            if (btn.Text == ".")
            {
                if (!textValue.Text.Contains("."))
                    textValue.Text = textValue.Text + btn.Text;

            }
            else
                textValue.Text = textValue.Text + btn.Text;
        }
        private void operation(object sender, EventArgs e)
        {
            Button btn = sender as Button;




            if (resultValue != 0)
            {
                button1.PerformClick();
                operationPerformed = btn.Text;
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = btn.Text;
                resultValue = Double.Parse(textValue.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }





        private void btnBack_Click(object sender, EventArgs e)
        {
            this.textValue.Text = textValue.Text.Remove(textValue.Text.Length - 1);
        }





        private void textValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textValue.Text = (resultValue + Double.Parse(textValue.Text)).ToString();
                    break;
                case "-":
                    textValue.Text = (resultValue - Double.Parse(textValue.Text)).ToString();
                    break;
                case "*":
                    textValue.Text = (resultValue * Double.Parse(textValue.Text)).ToString();
                    break;
                case "/":
                    textValue.Text = (resultValue / Double.Parse(textValue.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textValue.Text);

        }

        private void textValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
