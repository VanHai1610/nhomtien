using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhomtien
{
    public partial class Form1 : Form
    {
        private char[] Binary = new[] { '0', '1' };
        private char[] Octal = new[] { '0' , '1', '2', '3', '4', '5', '6', '7' };
        private char[] Hexadecimal = new[] { 'a' ,'b', 'c', 'd' ,'e', 'f' };

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && textBox1.Text.Length > 0)
            {
                textBox2.Text = Convert.ToString( Convert.ToInt32(textBox1.Text, 2), 8);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 10);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16);
            }
            if (comboBox2.SelectedIndex == 2 && textBox1.Text.Length > 0)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 8);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 16);
            }
            if (comboBox2.SelectedIndex == 1 && textBox1.Text.Length > 0)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 2);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 10);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 8), 16);
            }

            if (comboBox2.SelectedIndex == 3 && textBox1.Text.Length > 0)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 2);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 8);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 16), 10);

            }

            if (textBox1.Text.Length == 0)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label1.Text = "Binary";
                label2.Text = "Octal";
                label3.Text = "Decimal";
                label4.Text = "Hexadecimal";

            } 
            else if (comboBox2.SelectedIndex == 1)
            {
                label1.Text = "Octal";
                label2.Text = "Binary";
                label3.Text = "Decimal"; ;
                label4.Text = "Hexadecimal";

            }
            else if (comboBox2.SelectedIndex == 2)
            {
                label3.Text = "Octal";
                label1.Text = "Decimal";
                label2.Text = "Binary";
                label4.Text = "Hexadecimal";
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                label4.Text = "Decimal";
                label1.Text = "Hexadecimal";
                label2.Text = "Binary";
                label3.Text = "Octal";
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && !Binary.Contains(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (comboBox2.SelectedIndex == 1 && !Octal.Contains(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
            }

            if (comboBox2.SelectedIndex == 2 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (comboBox2.SelectedIndex == 3 && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !Hexadecimal.Contains(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
