using System;
using System.Windows.Forms;
using MathLib;
using HelpersLib;

namespace Task13App
{
    public partial class Form1 : Form
    {
        TextBox txtA, txtB;
        Button btnAdd, btnMul, btnSub, btnDiv;
        Label lblOut;

        public Form1()
        {
            InitializeComponent();
            Text = "Task 1.3 – Calculator (DLLs)";
            Width = 360; Height = 220;

            txtA = new TextBox { Left = 16, Top = 16, Width = 140, Text = "Number A" };
            txtB = new TextBox { Left = 16, Top = 48, Width = 140, Text = "Number B" };

            btnAdd = new Button { Left = 180, Top = 16, Width = 60, Text = "+" };
            btnSub = new Button { Left = 244, Top = 16, Width = 60, Text = "–" };
            btnMul = new Button { Left = 180, Top = 48, Width = 60, Text = "×" };
            btnDiv = new Button { Left = 244, Top = 48, Width = 60, Text = "÷" };

            lblOut = new Label { Left = 16, Top = 100, Width = 320, AutoSize = true };

            btnAdd.Click += (s, e) => Calculate(" + ", MathService.Add);
            btnSub.Click += (s, e) => Calculate(" - ", MathService.Subtract);
            btnMul.Click += (s, e) => Calculate(" × ", MathService.Multiply);
            btnDiv.Click += (s, e) =>
            {
                try { Calculate(" ÷ ", MathService.Divide); }
                catch (DivideByZeroException) { MessageBox.Show("Cannot divide by zero."); }
            };

            Controls.AddRange(new Control[] { txtA, txtB, btnAdd, btnSub, btnMul, btnDiv, lblOut });
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void Calculate(string op, Func<decimal, decimal, decimal> func)
        {
            if (decimal.TryParse(txtA.Text, out var a) && decimal.TryParse(txtB.Text, out var b))
            {
                var result = func(a, b);
                lblOut.Text = FormatService.FormatResult(op.Trim(), a, b, result);
            }
            else
            {
                MessageBox.Show("Enter valid numbers.");
            }
        }
    }
}
