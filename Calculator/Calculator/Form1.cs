﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
            {
                result.Clear();
            }
            operation_pressed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!result.Text.Contains("."))
                {
                    result.Text = result.Text + button.Text;
                }
            }
            else
                result.Text = result.Text + button.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
