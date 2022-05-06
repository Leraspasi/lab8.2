using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2___Calculator
{
    public partial class Form1 : Form
    {
        Calculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {}

        private void button3_Click(object sender, EventArgs e)
        {
            calculator.FirstArg = Convert.ToInt32(textBox1.Text);
            calculator.SecondArg = Convert.ToInt32(textBox2.Text);

            int result = calculator.AddMethod();

            label1.Text += $"{result}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculator.FirstArg = Convert.ToInt32(textBox1.Text);
            calculator.SecondArg = Convert.ToInt32(textBox2.Text);

            int result = calculator.SubMethod();

            label1.Text += $"{result}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculator.FirstArg = Convert.ToInt32(textBox1.Text);
            calculator.SecondArg = Convert.ToInt32(textBox2.Text);

            int result = calculator.MultiplyMethod();

            label1.Text += $"{result}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculator.FirstArg = Convert.ToInt32(textBox1.Text);
            calculator.SecondArg = Convert.ToInt32(textBox2.Text);
            if (calculator.SecondArg == 0)
            {
                label1.Text += "Помилка";
            }
            else
            {
                int result = (calculator.FirstArg / calculator.SecondArg);
                label1.Text += $"{result}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
    public class Calculator
    {
        public int FirstArg { get; set; }
        public int SecondArg { get; set; }
        public int AddMethod()
        {
            return FirstArg + SecondArg;
        }
        public int SubMethod()
        {
            return FirstArg - SecondArg;
        }
        public int MultiplyMethod()
        {
            return FirstArg * SecondArg;
        }
    }
}
