using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        private string _op = string.Empty;
        private double _result;
        string _num1, _num2, _tempString,_tempNum,_tempNumOfEq,_tempOp;
        private bool _enterValue;
        private bool _ifEqualClicked, _canDoEqual;
        private double _temporaryValue;
        private bool _hopToIf = true;
        private bool _hopToAddCountAfterComma = false;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
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
                else if (c == '+' || c =='-' || c== '*' || c=='/')
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
        private void buttonNum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = string.Empty;
            
            Button button = (Button)sender;
            if (_enterValue)
            {
                if (textBox1.Text.StartsWith("0,"))
                {
                    //textBox1.Text = string.Empty;
                    //textBox1.Text += "0,";
                }
                else
                {
                textBox1.Text = string.Empty;
                _enterValue = false;
                if (textBox2.Text.Contains("="))
                    textBox1.Text = string.Empty;
                }
            }
            if (textBox1.Text.Length < 15)
            {
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
        }

        private void buttonEqual_Click(object sender, EventArgs e) // =
        {
            _num2 = textBox1.Text;
            textBox2.Text = $"{textBox2.Text} {textBox1.Text}";
            if (_ifEqualClicked)
            {
                textBox2.Text = $"{textBox1.Text} {_tempOp} {_tempNumOfEq}";
                switch (_tempOp)
                {
                    case "+":
                        if (textBox2.Text.Contains("0 +"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        textBox1.Text = (_result + Double.Parse(_tempNumOfEq)).ToString();
                        textBox2.Text = ($"{_num2} {_tempOp} {_tempNumOfEq} = \n");
                        break;
                    case "-":
                        if (textBox2.Text.Equals("0 -"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        textBox1.Text = (_result - Double.Parse(_tempNumOfEq)).ToString();
                        textBox2.Text = ($"{_num2} {_tempOp} {_tempNumOfEq} = \n");
                        break;
                    case "*":
                        if(textBox2.Text.Equals("0 *"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        textBox1.Text = (_result * Double.Parse(_tempNumOfEq)).ToString();
                        textBox2.Text = ($"{_num2} {_tempOp} {_tempNumOfEq} = \n");
                        break;
                    case "/":
                        if (textBox2.Text.Equals("0 /"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        if (_temporaryValue == 0)
                        {
                            textBox2.Text = string.Empty;
                            buttonEqual.Enabled = false;
                            buttonEqual.BackColor = Color.Red;
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox1.Text = "Nie dziel przez 0";
                            break;
                        }
                        textBox1.Text = (_result / Double.Parse(_tempNumOfEq)).ToString();
                        textBox2.Text = ($"{_num2} {_tempOp} {_tempNumOfEq} = \n");
                        break;
                    default: break;
                }
            }
            else
            {
            if (textBox1.Text != string.Empty)
            {
                if(textBox1.Text == "0" )textBox2.Text = string.Empty;
                switch(_op)
                {
                    case "+":
                        if (textBox2.Text.Contains("0 +"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        textBox1.Text = (_result + Double.Parse(textBox1.Text)).ToString();
                        textBox2.Text  = ($"{_num1} {_num2} = \n");
                        break;
                    case "-":
                        if (textBox2.Text.Equals("0 -"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        textBox1.Text = (_result - Double.Parse(textBox1.Text)).ToString();
                        textBox2.Text = ($"{_num1} {_num2} = \n");
                        break;
                    case "*":
                        if(textBox2.Text.Equals("0 *"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        textBox1.Text = (_result * Double.Parse(textBox1.Text)).ToString();
                        textBox2.Text = ($"{_num1} {_num2} = \n");
                        break;
                    case "/":
                        if (textBox2.Text.Equals("0 /"))
                        {
                            textBox2.Text = string.Empty;
                        }
                        _temporaryValue = Double.Parse(textBox1.Text);
                        if(_temporaryValue == 0)
                        {
                            textBox2.Text = string.Empty;
                            buttonEqual.Enabled = false;
                            buttonEqual.BackColor = Color.Red;
                            textBox1.Enabled = false;
                            textBox2.Enabled = false;
                            textBox1.Text = "Nie dziel przez 0";
                            break;
                        }
                        textBox1.Text = (_result / Double.Parse(textBox1.Text)).ToString();
                        textBox2.Text = ($"{_num1} {_num2} = \n");
                        break;
                    default: textBox2.Text = $"{textBox1.Text} = "; break;
                }
                    
                }

            }
            if(_temporaryValue != 0 || _op != "/" )
                {
                    _result = Double.Parse(textBox1.Text);
                    textBox1.Text = _result.ToString();
                }
            if(_ifEqualClicked == false)
            {
                if(_temporaryValue !=0)
                {
                _tempOp = _op;
                _tempNumOfEq = ReverseString(textBox2.Text);
                _tempNumOfEq = checkSign(_tempNumOfEq);
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
            
            if (_result != 0 && _canDoEqual == true && !textBox2.Text.Contains("=")) buttonEqual.PerformClick();
            else 
            _result = Double.Parse(textBox1.Text);
            Button button = (Button)sender;
            _op = button.Text;
            _enterValue = true;
            _ifEqualClicked = false;
            if (textBox1.Text != "0")
            {
                if(!textBox1.Text.Equals("Nie dziel przez 0"))
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
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length-1);
                textBox2.Text += _op;
                _canDoEqual = false;
            }
            else
            {
                _canDoEqual = true;
            }
        }

        private void button7_Click(object sender, EventArgs e) // C
        {
            textBox1.Text = "0";
            textBox2.Text = string.Empty;
            _result = 0;
            buttonEqual.Enabled = true;
            buttonEqual.BackColor = SystemColors.ActiveBorder;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            _tempString = string.Empty;
            _num1 = string.Empty; 
            _num2 = string.Empty;
            _tempString = string.Empty;
            _tempNum = string.Empty;
            _tempNumOfEq = string.Empty;
            _tempOp = string.Empty;
            _hopToIf = true;
        }
        private void buttonCE_Click(object sender, EventArgs e) //CE
        {
            if (textBox2.Text.Contains("=")) textBox2.Text = string.Empty;
            if (textBox1.Text.Equals("Nie dziel przez 0"))
            {
                _op = "";
                textBox2.Text = string.Empty;
            }

            textBox1.Text = "0";
            buttonEqual.Enabled = true;
            buttonEqual.BackColor = SystemColors.ActiveBorder;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }
        private void button17_Click(object sender, EventArgs e) // ,
        {
            if (!textBox1.Text.EndsWith(","))
                if (!textBox1.Text.Contains(","))
                {
                    if (textBox1.Text.Equals("") || _enterValue) { textBox1.Text = "0"; };
                    textBox1.AppendText(",");
                    _hopToAddCountAfterComma = true;
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

        private void button18_Click(object sender, EventArgs e) // +/-
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

        private void buttonBack_Click(object sender, EventArgs e) // <-
        {
            if(!textBox2.Text.Contains("=") && _hopToIf == true)
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

    }
}