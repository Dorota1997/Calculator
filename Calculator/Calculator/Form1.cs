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

            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = button.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = button.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    // result.Text = (value + Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Add(value, Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    // result.Text = (value - Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Sub(value, Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    // result.Text = (value / Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Div(value, Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    // result.Text = (value * Double.Parse(result.Text)).ToString();
                    result.Text = Operators.Mult(value, Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Int32.Parse(result.Text);
            operation = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "ENTER":
                    one.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
