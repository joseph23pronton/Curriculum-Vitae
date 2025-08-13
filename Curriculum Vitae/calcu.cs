using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calcu : Form
    {
        double firstnum;
        string operation;
        string expression = "";

        public calcu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Calculator";
        }

        private void display_Click(object sender, EventArgs e)
        {
        }

        /* -----------------------------HELPER: AppendDigit with Formatting-------------------------------*/

        private void AppendDigit(string digit)
        {
            // Remove commas from current text
            string currentText = textBox1.Text.Replace(",", "");

            // Avoid invalid leading zero
            if (currentText == "0" && digit != ".")
            {
                currentText = "";
            }

            // Append digit
            currentText += digit;

            // Handle decimals
            if (currentText.Contains("."))
            {
                string[] parts = currentText.Split('.');
                string integerPart = parts[0];
                string decimalPart = parts.Length > 1 ? parts[1] : "";

                textBox1.Text = string.Format("{0:N0}", Convert.ToDouble(integerPart)) + "." + decimalPart;
            }
            else
            {
                if (double.TryParse(currentText, out double number))
                {
                    textBox1.Text = string.Format("{0:N0}", number);
                }
            }

            // Expression should always be raw (no commas)
            expression += digit;
        }

        /* -----------------------------NUMBER BUTTONS------------------------------------*/

        private void button1_Click(object sender, EventArgs e) => AppendDigit("1");
        private void button2_Click(object sender, EventArgs e) => AppendDigit("2");
        private void button3_Click(object sender, EventArgs e) => AppendDigit("3");
        private void button4_Click(object sender, EventArgs e) => AppendDigit("4");
        private void button5_Click(object sender, EventArgs e) => AppendDigit("5");
        private void button6_Click(object sender, EventArgs e) => AppendDigit("6");
        private void button7_Click(object sender, EventArgs e) => AppendDigit("7");
        private void button8_Click_1(object sender, EventArgs e) => AppendDigit("8");
        private void button9_Click(object sender, EventArgs e) => AppendDigit("9");
        private void button0_Click(object sender, EventArgs e) => AppendDigit("0");

        private void Decimal_Click(object sender, EventArgs e)
        {
            // Prevent multiple decimals in the current number
            string currentText = textBox1.Text.Replace(",", "");
            if (!currentText.Contains("."))
            {
                AppendDigit(".");
            }
        }

        /* -----------------------------OPERATIONS------------------------------------*/

        private void Add_Click_1(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text.Replace(",", ""));
            operation = "+";
            expression += "+";
            textBox1.Clear();
            display.Text = expression;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text.Replace(",", ""));
            operation = "-";
            expression += "-";
            textBox1.Clear();
            display.Text = expression;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text.Replace(",", ""));
            operation = "*";
            expression += "*";
            textBox1.Clear();
            display.Text = expression;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(textBox1.Text.Replace(",", ""));
            operation = "/";
            expression += "/";
            textBox1.Clear();
            display.Text = expression;
        }

        /* -----------------------------EQUAL CONDITIONS------------------------------------*/

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                display.Text = expression + " =";
                var result = new DataTable().Compute(expression, null);
                textBox1.Text = string.Format("{0:N0}", Convert.ToDouble(result));
                expression = result.ToString();
            }
            catch
            {
                textBox1.Text = "Invalid expression";
                expression = "";
            }
        }

        /* -----------------------------CLEAR BUTTON------------------------------------*/

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            display.Text = "";
            expression = "";
        }
    }
}
