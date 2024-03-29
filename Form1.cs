using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        private string _op = string.Empty;
        private double _result, _temporaryValue;
        string _num1, _num2, _tempString, _tempNum, _tempNumOfEq, _tempOp;
        private bool _enterValue;
        private bool _ifEqualClicked, _canDoEqual;
        private bool _hopToIf = true;
        private List<Button> buttonGroup = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            AddButtonsToGroup(this);
        }
        private string checkSign(string textBox)
        {
            StringBuilder numberBuilder = new StringBuilder();

            foreach (char c in textBox)
            {
                if (Char.IsDigit(c))
                {
                    numberBuilder.Append(c);
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    break;
                }
            }
            string number = numberBuilder.ToString();
            return number;
        }
        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private string addCommaToDouble(string tempValue)
        {
            string returnedValue = "0,";
            ReverseString(tempValue);
            foreach (char ch in tempValue)
            {
                returnedValue += ch;
            }
            returnedValue = returnedValue.Substring(0, returnedValue.Length - 1);
            return returnedValue;
        }
        private void buttonNum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = string.Empty;

            Button button = (Button)sender;
            if (_enterValue)
            {
                if (textBox2.Text.Contains("="))
                {
                    textBox2.Text = string.Empty;
                    if (textBox1.Text.StartsWith("0,"))
                        textBox1.Text = string.Empty;
                }
                else if (textBox2.Text.Contains("+") || textBox2.Text.Contains("-") || textBox2.Text.Contains("*") || textBox2.Text.Contains("/"))
                {
                    if (textBox1.Text.StartsWith("0,"))
                        textBox1.Text = string.Empty;
                }
                if (!textBox1.Text.StartsWith("0,"))
                {
                    textBox1.Text = string.Empty;
                    _enterValue = false;
                    if (textBox2.Text.Contains("="))
                        textBox1.Text = string.Empty;
                }
            }
            if (button.Text == ",")
            {
                textBox1.Text += "0";
                textBox1.Text += button.Text;
            }
            textBox1.Text += button.Text;
            _canDoEqual = true;
            _ifEqualClicked = false;
            _hopToIf = true;
        }
        private void calculateTheResultVia(string equationOperator,string secondOperand, bool equalClicked)
        {
            if (textBox2.Text.Contains("0 ") && textBox2.Text.Contains(equationOperator))
            {
                textBox2.Text = string.Empty;
            }
            _temporaryValue = Double.Parse(textBox1.Text);
            switch(equationOperator)
            {
                case "+": textBox1.Text = (_result + Double.Parse(secondOperand)).ToString(); break;
                case "-": textBox1.Text = (_result - Double.Parse(secondOperand)).ToString(); break;
                case "*": textBox1.Text = (_result * Double.Parse(secondOperand)).ToString(); break;
                case "/":
                    if (_temporaryValue == 0)
                    {
                        textBox2.Text = string.Empty;
                        buttonEqual.Enabled = false;
                        buttonEqual.BackColor = Color.Red;
                        textBox1.Enabled = false;
                        textBox2.Enabled = false;
                        ToggleGroupEnabled(false);
                        textBox1.Text = "Nie dziel przez 0";
                        break;
                    }
                    textBox1.Text = (_result / Double.Parse(secondOperand)).ToString(); break;
                default: break;
            }
            if(equalClicked)
                textBox2.Text = ($"{_num2} {_tempOp} {secondOperand} = \n");
            else
                textBox2.Text = ($"{_num1} {_num2} = \n");
            if (_temporaryValue == 0 && equationOperator == "/")
                textBox2.Text = string.Empty;
        }
        private void AddButtonsToGroup(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Button button)
                {
                    buttonGroup.Add(button);
                }
                else if (ctrl.HasChildren)
                {
                    AddButtonsToGroup(ctrl);
                }
            }
            buttonGroup.Remove(buttonCE);
            buttonGroup.Remove(buttonClear);
        }
        private void ToggleGroupEnabled(bool enabled)
        {
            foreach (Button button in buttonGroup)
            {
                button.Enabled = enabled;
            }
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            _num2 = textBox1.Text;
            textBox2.Text = $"{textBox2.Text} {textBox1.Text}";
            if (_ifEqualClicked)
            {
                textBox2.Text = $"{textBox1.Text} {_tempOp} {_tempNumOfEq}";
                switch (_tempOp)
                {
                    case "+":
                        calculateTheResultVia(_tempOp, _tempNumOfEq, _ifEqualClicked);
                        break;
                    case "-":
                        calculateTheResultVia(_tempOp, _tempNumOfEq, _ifEqualClicked);
                        break;
                    case "*":
                        calculateTheResultVia(_tempOp, _tempNumOfEq, _ifEqualClicked);
                        break;
                    case "/":
                        calculateTheResultVia(_tempOp, _tempNumOfEq, _ifEqualClicked);
                        break;
                    default: textBox2.Text = $"{textBox1.Text} = "; break;
                }
            }
            else
            {
                if (textBox1.Text != string.Empty)
                {
                    if (textBox1.Text == "0") textBox2.Text = string.Empty;
                    switch (_op)
                    {
                        case "+":
                            calculateTheResultVia(_op, textBox1.Text, _ifEqualClicked);
                            break;
                        case "-":
                            calculateTheResultVia(_op, textBox1.Text, _ifEqualClicked);
                            break;
                        case "*":
                            calculateTheResultVia(_op, textBox1.Text, _ifEqualClicked);
                            break;
                        case "/":
                            calculateTheResultVia(_op, textBox1.Text, _ifEqualClicked);
                            break;
                        default: textBox2.Text = $"{textBox1.Text} = "; break;
                    }
                }
            }
            if (_temporaryValue != 0 || _op != "/")
            {
                _result = Double.Parse(textBox1.Text);
                _result = Math.Round(_result, 14);
                textBox1.Text = _result.ToString();
            }
            if (_ifEqualClicked == false)
            {
                if (_temporaryValue != 0)
                {
                    _tempOp = _op;
                    _tempNumOfEq = ReverseString(textBox2.Text);
                    if (_temporaryValue > 0 && _temporaryValue < 1)
                    {
                        _tempNumOfEq = checkSign(_tempNumOfEq);
                        _tempNumOfEq = addCommaToDouble(_tempNumOfEq);
                    }
                    else
                    {
                        _tempNumOfEq = checkSign(_tempNumOfEq);
                    }
                }
                else
                {
                    _tempOp = _op;
                }
            }
            _op = string.Empty;
            _enterValue = true;
            _ifEqualClicked = true;

        }

        private void buttonMathOperation_Click(object sender, EventArgs e)
        {

            if (_result != 0 && _canDoEqual == true && !textBox2.Text.Contains("=")) 
                buttonEqual.PerformClick();
            else
                _result = Double.Parse(textBox1.Text);

            Button button = (Button)sender;
            _op = button.Text;
            _enterValue = true;
            _ifEqualClicked = false;

            if (textBox1.Text != "0")
            {
                if (!textBox1.Text.Equals("Nie dziel przez 0"))
                {
                    textBox2.Text = _num1 = $"{_result} {_op}";
                }
            }
            else
            {
                textBox2.Text = _num1 = $"{_result} {_op}";
            }
            _tempNum = checkSign(_num1);
            _tempString = checkSign(textBox2.Text);
            if (_tempNum.Equals(_tempString))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                textBox2.Text += _op;
                _canDoEqual = false;
            }
            else
            {
                _canDoEqual = true;
            }
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("=")) textBox2.Text = string.Empty;
            if (textBox1.Text.Equals("Nie dziel przez 0"))
            {
                _op = "";
                textBox2.Text = string.Empty;
            }
            buttonEqual.BackColor = SystemColors.MenuHighlight;
            textBox1.Text = "0";
            buttonEqual.Enabled = textBox1.Enabled = textBox2.Enabled = true;
            ToggleGroupEnabled(true);
        }
        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith(","))
                if (!textBox1.Text.Contains(","))
                {
                    if (textBox1.Text.Equals("") || _enterValue) { textBox1.Text = "0"; textBox2.Text = string.Empty; };
                    textBox1.AppendText(",");
                }
                else if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/"))
                {
                    textBox1.Text = "0,";
                }
                else if (textBox2.Text.EndsWith("= \n"))
                {
                    textBox1.Text = "0,"; textBox2.Text = string.Empty;
                }
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
                if (!textBox1.Text.Equals(""))
                {
                    if (!textBox1.Text.StartsWith("-"))
                        textBox1.Text = "-" + textBox1.Text;
                    else
                        textBox1.Text = textBox1.Text[1..];
                }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Contains("=") && _hopToIf == true)
            {
                if (textBox1.Text.Length > 1)
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                else
                    textBox1.Text = "0";
            }
            else
            {
                textBox2.Text = string.Empty;
                _hopToIf = false;
                _canDoEqual = false;
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            _result = 0;
            ToggleGroupEnabled(true);
            buttonEqual.BackColor = SystemColors.MenuHighlight;
            textBox1.Enabled = textBox2.Enabled = _hopToIf = true;
            textBox2.Enabled = true;
            textBox2.Text = _tempString = _num1 = _num2 = _tempString = _tempNum = _tempNumOfEq = _tempOp = string.Empty;
        }
    }
}