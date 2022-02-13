using static System.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calc = ClassLib_Calc_50311.Calculator;

namespace WinForms_Calc_50311
{
    public partial class Form1 : Form
    {
        private int _first_value = 0;
        private int _second_value = 0;
        public Form1()
        {
            InitializeComponent();
            textBox_first_TextChanged(null, null);
        }

        private void textBox_first_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_first.Text, out value)) _first_value = value;
            else _first_value = 0;
            if (textBox_first.Text != "" && textBox_first.Text != "-")
            {
                button_zvd.Enabled = true; button_div.Enabled = true;
                button_and.Enabled = true; button_zvd.Enabled = true;
                if (textBox_second.Text != "")
                {
                    button_zvd.Enabled = true; button_div.Enabled = true;
                    button_and.Enabled = true; button_zvd.Enabled = true;
                    if (textBox_second.Text == "0") button_div.Enabled = false; else button_div.Enabled = true;
                }
            }
            else
            {
                button_zvd.Enabled = false; button_div.Enabled = false;
                button_and.Enabled = false; button_zvd.Enabled = false;
            }
            return;
        }

        private void textBox_second_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_second.Text, out value)) _second_value = value;
            else _second_value = 0;
            if (textBox_second.Text != "" && textBox_second.Text != "-" && textBox_first.Text != "")
            {
                button_zvd.Enabled = true; button_div.Enabled = true;
                button_and.Enabled = true; button_zvd.Enabled = true;
                if (textBox_second.Text == "0") button_div.Enabled = false; else button_div.Enabled = true;
            }
            else
            {
                button_zvd.Enabled = false; button_div.Enabled = false;
                button_and.Enabled = false; button_zvd.Enabled = false;
            }
            return;
        }

        private void button_zvd_Click(object sender, EventArgs e)
        {
            string str_message = Calc.zvd((sbyte)_first_value, (sbyte)_second_value);
            int a = int.Parse(str_message);
            if (a < Abs(150))
                MessageBox.Show("Значение противоречит условию (y<=Abs(150))", "Ошибка!", 0);
            else label.Text = str_message;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            string str_message = Calc.div((sbyte)_first_value, (sbyte)_second_value);
            if (_second_value < 50 && _first_value < 50 || _second_value < 50 || _first_value < 50)
                MessageBox.Show("Значение противоречит условию (x & y>=50)", "Ошибка!", 0);
            else label.Text = str_message;
            textBox_first.Text = str_message;

        }

        private void button_and_Click(object sender, EventArgs e)
        {
            string str_message = Calc.and((sbyte)_first_value, (sbyte)_second_value);
            int a = int.Parse(str_message);
            if (_second_value < 50 && _first_value < 50 || _second_value < 50 || _first_value < 50)
                MessageBox.Show("Значение противоречит условию (x&y>=50)", "Ошибка!", 0);
            else label.Text = str_message;
        }

        private void button_zum_Click(object sender, EventArgs e)
        {
            string str_message = Calc.zum((sbyte)_first_value, (sbyte)_second_value);
            if (_first_value > 40)
                MessageBox.Show("Значение противоречит условию (y<=40)", "Ошибка!", 0);
            else label_text.Text = str_message;

        }

        private void textBox_first_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_first.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-')) return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox_first.Text == "-")) return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox_first.Text != "0") && (textBox_first.Text != "-")) return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;

        }

        private void textBox_second_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_second.Text == "")
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-')) return;
            }
            else
            {
                if ((e.KeyChar >= '1') && (e.KeyChar <= '9') && (textBox_second.Text == "-")) return;
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9') && (textBox_second.Text != "0") && (textBox_second.Text != "-")) return;
            }
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}

