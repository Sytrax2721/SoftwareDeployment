using System;
using System.Drawing;
using System.Windows.Forms;

namespace ExampleDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "WiX Demo – Calculator (Task 1.2)";
            ClientSize = new Size(320, 200);

            var lblTitle = new Label { Left = 16, Top = 12, AutoSize = true, Text = "Add two numbers:" };

            var lblA = new Label { Left = 16, Top = 40, AutoSize = true, Text = "First" };
            var txtA = new TextBox { Name = "txtA", Left = 80, Top = 36, Width = 120 };

            var lblB = new Label { Left = 16, Top = 72, AutoSize = true, Text = "Second" };
            var txtB = new TextBox { Name = "txtB", Left = 80, Top = 68, Width = 120 };

            var btn = new Button { Text = "Add", Left = 16, Top = 100, Width = 184, Height = 30 };
            var lblOut = new Label { Name = "lblOut", Left = 16, Top = 144, AutoSize = true, Text = "Result: -" };

            btn.Click += (s, e) =>
            {
                if (decimal.TryParse(txtA.Text, out var x) && decimal.TryParse(txtB.Text, out var y))
                    lblOut.Text = $"Result: {x + y}";
                else
                    MessageBox.Show("Enter valid numbers.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };

            Controls.AddRange(new Control[] { lblTitle, lblA, txtA, lblB, txtB, btn, lblOut });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
