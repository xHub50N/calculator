
namespace kalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            button10 = new System.Windows.Forms.Button();
            buttonCE = new System.Windows.Forms.Button();
            buttonBack = new System.Windows.Forms.Button();
            buttonPM = new System.Windows.Forms.Button();
            buttonComma = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            buttonMulti = new System.Windows.Forms.Button();
            buttonDivide = new System.Windows.Forms.Button();
            buttonMinus = new System.Windows.Forms.Button();
            buttonPlus = new System.Windows.Forms.Button();
            buttonClear = new System.Windows.Forms.Button();
            buttonEqual = new System.Windows.Forms.Button();
            button0 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            groupBox1.Controls.Add(button10);
            groupBox1.Controls.Add(buttonCE);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(buttonPM);
            groupBox1.Controls.Add(buttonComma);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(buttonMulti);
            groupBox1.Controls.Add(buttonDivide);
            groupBox1.Controls.Add(buttonMinus);
            groupBox1.Controls.Add(buttonPlus);
            groupBox1.Controls.Add(buttonClear);
            groupBox1.Controls.Add(buttonEqual);
            groupBox1.Controls.Add(button0);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            groupBox1.Location = new System.Drawing.Point(0, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(351, 531);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // button10
            // 
            button10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button10.Location = new System.Drawing.Point(184, 230);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(50, 50);
            button10.TabIndex = 22;
            button10.Text = "√";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // buttonCE
            // 
            buttonCE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonCE.Location = new System.Drawing.Point(106, 174);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new System.Drawing.Size(50, 50);
            buttonCE.TabIndex = 21;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = false;
            buttonCE.Click += buttonCE_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonBack.Location = new System.Drawing.Point(262, 174);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(50, 50);
            buttonBack.TabIndex = 20;
            buttonBack.Text = "<-";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonPM
            // 
            buttonPM.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonPM.Location = new System.Drawing.Point(28, 454);
            buttonPM.Name = "buttonPM";
            buttonPM.Size = new System.Drawing.Size(50, 50);
            buttonPM.TabIndex = 19;
            buttonPM.Text = "+/-";
            buttonPM.UseVisualStyleBackColor = false;
            buttonPM.Click += button18_Click;
            // 
            // buttonComma
            // 
            buttonComma.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonComma.Location = new System.Drawing.Point(184, 454);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new System.Drawing.Size(50, 50);
            buttonComma.TabIndex = 18;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = false;
            buttonComma.Click += button17_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox2.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(12, 22);
            textBox2.MaxLength = 100;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(326, 46);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonMulti
            // 
            buttonMulti.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonMulti.Location = new System.Drawing.Point(262, 286);
            buttonMulti.Name = "buttonMulti";
            buttonMulti.Size = new System.Drawing.Size(50, 50);
            buttonMulti.TabIndex = 16;
            buttonMulti.Text = "*";
            buttonMulti.UseVisualStyleBackColor = false;
            buttonMulti.Click += buttonMult_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonDivide.Location = new System.Drawing.Point(262, 230);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new System.Drawing.Size(50, 50);
            buttonDivide.TabIndex = 15;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivi_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonMinus.Location = new System.Drawing.Point(262, 342);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new System.Drawing.Size(50, 50);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonPlus.Location = new System.Drawing.Point(262, 398);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new System.Drawing.Size(50, 50);
            buttonPlus.TabIndex = 13;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonAdd_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonClear.Location = new System.Drawing.Point(184, 174);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new System.Drawing.Size(50, 50);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += button7_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = System.Drawing.SystemColors.ActiveBorder;
            buttonEqual.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonEqual.Location = new System.Drawing.Point(262, 454);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new System.Drawing.Size(50, 50);
            buttonEqual.TabIndex = 11;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // button0
            // 
            button0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button0.Location = new System.Drawing.Point(106, 454);
            button0.Name = "button0";
            button0.Size = new System.Drawing.Size(50, 50);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += buttonNum_Click;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button9.Location = new System.Drawing.Point(184, 286);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(50, 50);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += buttonNum_Click;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button8.Location = new System.Drawing.Point(106, 286);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(50, 50);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += buttonNum_Click;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button7.Location = new System.Drawing.Point(28, 286);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(50, 50);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += buttonNum_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            textBox1.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(12, 81);
            textBox1.MaxLength = 100;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            textBox1.Size = new System.Drawing.Size(326, 46);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button6.Location = new System.Drawing.Point(184, 342);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(50, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += buttonNum_Click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button5.Location = new System.Drawing.Point(106, 342);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(50, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += buttonNum_Click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button4.Location = new System.Drawing.Point(28, 342);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(50, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonNum_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button3.Location = new System.Drawing.Point(184, 398);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(50, 50);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonNum_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button2.Location = new System.Drawing.Point(106, 398);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(50, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonNum_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            button1.Location = new System.Drawing.Point(28, 398);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonNum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(351, 519);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button button10;
    }
}

