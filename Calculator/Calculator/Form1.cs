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
    public partial class Calculator : Form
    {
        public delegate float Math(float x, float y);
        public Calculator()
        {
            InitializeComponent();
        }

        float firstNumber = 0, secondNumber = 0;
        int type;
        bool makeEquation = false, equalSignClicked = false;
        string resultText;

        private void button0_Click(object sender, EventArgs e)
        {
            calculate(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculate(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculate(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculate(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculate(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculate(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculate(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculate(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calculate(9);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            type = 1;
            makeEquation = true;
            equalSignClicked = false;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            type = 2;
            makeEquation = true;
            equalSignClicked = false;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            type = 3;
            makeEquation = true;
            equalSignClicked = false;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            type = 4;
            makeEquation = true;
            equalSignClicked = false;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ResultTextBox.Text))
            {
                if (equalSignClicked)
                    firstNumber = float.Parse(ResultTextBox.Text);
                else secondNumber = float.Parse(ResultTextBox.Text);
            }

            
            ResultTextBox.Clear();
            Math Calc = new Math(add); ;
            switch (type)
            {
                
                case 1: // add
                    {
                        Calc = new Math(add);
                        break;
                    }
                case 2: // sub
                    {
                        Calc = new Math(substract);
                        break;
                    }
                case 3: // multiply
                    {
                        Calc = new Math(multiply);
                        break;
                    }
                case 4: // divide
                    {
                        Calc = new Math(divide);
                        break;
                    }
                default: break;
                
            }

         
            ResultTextBox.Text = Convert.ToString(Calc(firstNumber, secondNumber));
            equalSignClicked = true;

            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            type = 0;
            ResultTextBox.Clear();
            resultText = "";
            firstNumber = 0;
            secondNumber = 0;
        }

        private float add(float x, float y)
        {
            return (x + y);
        }


        private float substract(float x, float y)
        {
            return (x - y);
        }

        private float multiply(float x, float y)
        {
            return (x * y);
        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = ResultTextBox.Text.Remove(ResultTextBox.Text.Length-1, 1);
        }

        private float divide(float x, float y)
        {
            return x / y;          
        }

        private void calculate(float number)
        {

            equalSignClicked = false;
            if (makeEquation)
            {
                if (!String.IsNullOrEmpty(ResultTextBox.Text))
                    firstNumber = float.Parse(ResultTextBox.Text);

                ResultTextBox.Clear();
                resultText = number.ToString();
                ResultTextBox.Text = resultText;
                makeEquation = false;

            }
            else
            {
                resultText += number;
                ResultTextBox.Text = resultText;
            }
            
        }



    }
}
