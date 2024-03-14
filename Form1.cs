using System;
using System.Drawing;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        private string _op = "";
        private decimal _result;
        private decimal _num1, _num2;
        private bool _enterValue;
        private bool _ifClicked;
        private bool _sequenceOfActions;
        private decimal _tempDouble;
        private decimal _tempResult;
        private int _iterator;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = string.Empty;
            if (_enterValue)
            {
                textBox1.Text = string.Empty;
                _enterValue = false;
                if (textBox2.Text.Contains("="))
                    textBox2.Text = string.Empty;
            }

            var button = (Button)sender;
            if (textBox1.Text.Length < 15) textBox1.Text = textBox1.Text + button.Text;
        }

        private void buttonEqual_Click(object sender, EventArgs e) // =
        {
            _num2 = decimal.Parse(textBox1.Text);
            if (_op.Equals("+"))
            {
                if (!_ifClicked)
                {
                    _tempDouble = _num2;
                    textBox2.Clear();
                    if(_sequenceOfActions == false)
                    {
                    _result = _num1 + _num2;
                    textBox1.Text = _result.ToString();
                    if (_num2 < 0)
                        textBox2.AppendText($"{_num1} + ({_num2}) = ");
                    else
                        textBox2.AppendText($"{_num1} + {_num2} = ");
                    _ifClicked = true;
                    }
                    else
                    {
                        if(_iterator < 1)
                        {
                        _result = _num2 + _num1;
                        }
                        else
                        {
                            _num1 = decimal.Parse(textBox1.Text);
                            _result += _num1;
                        }
                        textBox1.Text = _result.ToString();
                        textBox2.AppendText($"{_result} +");
                        _iterator++;
                    }
                    
                    }
                else
                {
                    textBox2.Clear();
                    _result = _num2 + _tempDouble;
                    textBox1.Text = _result.ToString();
                    if (_tempDouble < 0)
                        textBox2.AppendText($"{_num2} + ({_tempDouble}) = ");
                    else
                        textBox2.AppendText($"{_num2} + {_tempDouble} = ");
                }
            }

            if (_op.Equals("-"))
            {
                if (!_ifClicked)
                {
                    _tempDouble = _num2;
                    textBox2.Clear();
                    _result = _num1 - _num2;
                    _result = Math.Round(_result, 2);
                    textBox1.Text = _result.ToString();
                    if (_num2 > 0)
                        textBox2.AppendText($"{_num1} - {_num2} = ");
                    else
                        textBox2.AppendText($"{_num1} - ({_num2}) = ");
                    _ifClicked = true;
                    
                }
                else
                {
                    textBox2.Clear();
                    _result = _num2 - _tempDouble;
                    textBox1.Text = _result.ToString();
                    if (_tempDouble < 0)
                        textBox2.AppendText($"{_num2} - ({_tempDouble}) = ");
                    else
                        textBox2.AppendText($"{_num2} - {_tempDouble} = ");
                }
            }

            if (_op.Equals("*"))
            {
                if (!_ifClicked)
                {
                    _tempDouble = _num2;
                    textBox2.Clear();
                    _result = _num1 * _num2;
                    textBox1.Text = _result.ToString();
                    textBox2.AppendText($"{_num1}  * {_num2} = ");
                    _ifClicked = true;
                }
                else
                {
                    textBox2.Clear();
                    _result = _num2 * _tempDouble;
                    textBox1.Text = _result.ToString();
                    textBox2.AppendText($"{_num2} * {_tempDouble} = ");
                }
            }

            if (_op.Equals("/"))
            {
                if (!_ifClicked)
                {
                    if (_num2 == 0)
                    {
                        textBox1.Text = "Infinity";
                        buttonEqual.Enabled = false;
                        buttonEqual.BackColor = Color.Red;
                    }
                    else
                    {
                        _tempDouble = _num2;
                        textBox2.Clear();
                        _result = _num1 / _num2;
                        textBox1.Text = _result.ToString();
                        textBox2.AppendText($"{_num1} / {_num2} = ");
                    }

                    _ifClicked = true;
                }
                else
                {
                    {
                        textBox2.Clear();
                        _result = _num2 / _tempDouble;
                        _result = Math.Round(_result, 15);
                        if (_result == 0)
                        {
                            textBox1.Text = "0";
                            _num2 = 0;
                        }
                        else
                        {
                            textBox1.Text = _result.ToString();
                        }

                        textBox2.AppendText($"{_num2} / {_tempDouble} = ");
                    }
                }
            }
            _enterValue = true;
            if (textBox1.Text.Length > 15) textBox1.Text = textBox1.Text.Substring(0, 15);
        }

        private void button7_Click(object sender, EventArgs e) // C
        {
            textBox1.Text = "0";
            textBox2.Clear();
            _result = 0;
            _num1 = 0;
            _num2 = 0;
            _enterValue = false;
            _ifClicked = false;
            _tempDouble = 0;
            buttonEqual.Enabled = true;
            _op = "";
            buttonEqual.BackColor = SystemColors.ActiveBorder;
            _iterator = 0;
            _sequenceOfActions = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e) //+
        {
            _ifClicked = false;
            _op = "+";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") ||
                textBox2.Text.EndsWith("/"))
            {
                if(_result != decimal.Parse(textBox1.Text))
                {
                    _sequenceOfActions = true;
                    buttonEqual_Click(sender, e);
                }
                else
                {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "+";
                }
                
            }
            else
            {
                textBox2.Clear();
                _num1 = decimal.Parse(textBox1.Text);
                textBox2.AppendText($"{_num1} +");
                _enterValue = true;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e) //-
        {
            _ifClicked = false;
            _op = "-";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") ||
                textBox2.Text.EndsWith("/"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "-";
            }
            else
            {
                textBox2.Clear();
                _num1 = decimal.Parse(textBox1.Text);
                textBox2.AppendText($"{_num1} -");
                _enterValue = true;
            }
        }

        private void buttonMult_Click(object sender, EventArgs e) // *
        {
            _ifClicked = false;
            _op = "*";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") ||
                textBox2.Text.EndsWith("/"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "*";
            }
            else
            {
                textBox2.Clear();
                _num1 = decimal.Parse(textBox1.Text);
                textBox2.AppendText($"{_num1} *");
                _enterValue = true;
            }
        }

        private void buttonDivi_Click(object sender, EventArgs e) // /
        {
            _ifClicked = false;
            _op = "/";
            if (textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") ||
                textBox2.Text.EndsWith("/"))
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                textBox2.Text += "/";
            }
            else
            {
                textBox2.Clear();
                _num1 = decimal.Parse(textBox1.Text);
                textBox2.AppendText($"{_num1} /");
                _enterValue = true;
            }
        }

        private void button17_Click(object sender, EventArgs e) // ,
        {
            if (!textBox1.Text.EndsWith(","))
                if (!textBox1.Text.Contains(","))
                {
                    if (textBox1.Text.Equals("") || _enterValue) textBox1.Text = "0";
                    textBox1.AppendText(",");
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
            if (textBox2.Text != string.Empty)
            {
                textBox2.Text = string.Empty;
            }
            else
            {
                if (textBox1.Text.Length > 1)
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                else
                    textBox1.Text = "0";
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Contains("=")) textBox2.Text = string.Empty;
            if (textBox1.Text.Equals("Infinity"))
            {
                _op = "";
                textBox2.Text = string.Empty;
            }

            textBox1.Text = "0";
            buttonEqual.Enabled = true;
            buttonEqual.BackColor = SystemColors.ActiveBorder;
        }
    }
}