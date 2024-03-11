using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        string op = "";
        double result = 0;
        double num1, num2 = 0;
        bool enterValue = false;
        bool ifClicked = false;
        double tempDouble = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = string.Empty;
            if (enterValue)
            {
                textBox1.Text = string.Empty;
            }
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void buttonEqual_Click(object sender, EventArgs e) // =
        {
            num2 = double.Parse(textBox1.Text);
            if (op.Equals("+"))
            {
                if (!ifClicked)
                {
                    tempDouble = num2;
                    textBox2.Clear();
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    if (num2 < 0)
                    {
                        textBox2.AppendText($"{num1} + ({num2}) = \n");
                    }
                    else
                    {
                        textBox2.AppendText($"{num1} + {num2} = \n");
                    }
                    ifClicked = true;
                }
                else
                {
                    textBox2.Clear();
                    result = num2 + tempDouble;
                    textBox1.Text = result.ToString();
                    if (num2 < 0)
                    {
                        textBox2.AppendText($"{num2} + ({tempDouble}) = \n");
                    }
                    else
                    {
                        textBox2.AppendText($"{num2} + {tempDouble} = \n");
                    }
                }

            }
            if (op.Equals("-"))
            {
                if (!ifClicked)
                {
                    tempDouble = num2;
                    textBox2.Clear();
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    if (num2 < 0)
                    {
                        textBox2.AppendText($"{num1} - ({num2}) = \n");
                    }
                    else
                    {
                        textBox2.AppendText($"{num1} - {num2} = \n");
                    }
                    ifClicked = true;
                }
                else
                {
                    textBox2.Clear();
                    result = num2 - tempDouble;
                    textBox1.Text = result.ToString();
                    if (num2 < 0)
                    {
                        textBox2.AppendText($"{num2} - ({tempDouble}) = \n");
                    }
                    else
                    {
                        textBox2.AppendText($"{num2} - {tempDouble} = \n");
                    }
                }
            }
            if (op.Equals("*"))
            {
                if (!ifClicked)
                {
                    tempDouble = num2;
                    textBox2.Clear();
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    textBox2.AppendText($"{num1}  * {num2} = \n");
                    ifClicked = true;
                }
                else
                {
                    textBox2.Clear();
                    result = num2 * tempDouble;
                    textBox1.Text = result.ToString();
                    textBox2.AppendText($"{num2} * {tempDouble} = \n");

                }
            }
            if (op.Equals("/"))
            {
                if (!ifClicked)
                {
                    if (num2 == 0)
                    {
                        textBox1.Text = "Inf";
                    }
                    else
                    {
                        tempDouble = num2;
                        textBox2.Clear();
                        result = num1 / num2;
                        textBox1.Text = result.ToString();
                        textBox2.AppendText($"{num1} / {num2} = \n");
                    }
                    ifClicked = true;
                }
                else
                {
                    if (result == 0)
                    {
                        textBox1.Text = "Inf";
                    }
                    else
                    {
                        textBox2.Clear();
                        result = num2 / tempDouble;
                        textBox1.Text = result.ToString();
                        textBox2.AppendText($"{num2} / {tempDouble} = \n");
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e) // C
        {
            textBox1.Text = "0";
            textBox2.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
            enterValue = false;
            ifClicked = false;
            tempDouble = 0;
        }
        private void buttonAdd_Click(object sender, EventArgs e)//+
        {
            ifClicked = false;
            op = "+";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "+";
            }
            else
            {
                textBox2.Clear();
                num1 = double.Parse(textBox1.Text);
                textBox2.AppendText($"{num1} +");
                enterValue = true;
            }

        }
        private void buttonMinus_Click(object sender, EventArgs e) //-
        {
            ifClicked = false;
            op = "-";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "-";
            }
            else
            {
                textBox2.Clear();
                num1 = double.Parse(textBox1.Text);
                textBox2.AppendText($"{num1} -");
                enterValue = true;
            }
        }
        private void buttonMult_Click(object sender, EventArgs e) // *
        {
            ifClicked = false;
            op = "*";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "*";
            }
            else
            {
                textBox2.Clear();
                num1 = double.Parse(textBox1.Text);
                textBox2.AppendText($"{num1} *");
                enterValue = true;
            }
        }

        private void buttonDivi_Click(object sender, EventArgs e) // /
        {
            ifClicked = false;
            op = "/";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "/";
            }
            else
            {
                textBox2.Clear();
                num1 = double.Parse(textBox1.Text);
                textBox2.AppendText($"{num1} /");
                enterValue = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)// ,
        {
            if (!textBox1.Text.EndsWith(","))
            {
                if (!textBox1.Text.Contains(","))
                {
                    if (textBox1.Text.Equals(""))
                    {
                        textBox1.Text = "0";
                    }
                    textBox1.AppendText(",");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e) // +/-
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!textBox1.Text.Equals(""))
                {
                    if (!textBox1.Text.StartsWith("-"))
                    {
                        textBox1.Text = "-" + textBox1.Text;
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text[1..];
                    }
                }
            }
        }
        private void buttonBack_Click(object sender, EventArgs e) // <-
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Contains("="))
            {
                textBox2.Text = string.Empty;
            }
                textBox1.Text = "0";
        }
    }
}
