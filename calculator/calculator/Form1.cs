using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isoOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (display_res.Text == "0" || (isoOperationPerformed))
                display_res.Clear();

            isoOperationPerformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!display_res.Text.Contains("."))
                    display_res.Text += button.Text;
            }
            else
            {
                display_res.Text += button.Text;
            }

        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            resultValue = Double.Parse(display_res.Text);
            current_op.Text = resultValue + "" + operationPerformed;
            isoOperationPerformed = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display_res.Text = "0";
            resultValue = 0;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            display_res.Text = "0";
        }

        private void button_eq_Click(object sender, EventArgs e)
        {
            if (operationPerformed == "+")
            {
                display_res.Text = (resultValue + double.Parse(display_res.Text)).ToString();
            }
            else if (operationPerformed == "-")
            {
                display_res.Text = (resultValue - double.Parse(display_res.Text)).ToString();
            }
            else if (operationPerformed == "x")
            {
                display_res.Text = (resultValue * double.Parse(display_res.Text)).ToString();
            }
            else
            {
                display_res.Text = (resultValue / double.Parse(display_res.Text)).ToString();
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (display_res.Text.Length > 0)
                display_res.Text = display_res.Text.Remove(display_res.Text.Length - 1, 1);

            if (display_res.Text == "")
                display_res.Text = "0";
        }
    }
}
