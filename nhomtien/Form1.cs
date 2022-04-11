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
        internal string[] myCollection = new string[] { "Decimal", "Binary", "Octal", "Hexadecimal" };
        private Keys[] Binary = new[] { Keys.Back, Keys.D0, Keys.D1 };
        private Keys[] Octal = new[] { Keys.Back, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8 };
        private char[] Hexadecimal = new[] { 'a', 'b', 'c', 'd', 'e', 'f' };

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0 && textBox1.Text.Length > 0)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 2);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 8);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 16);

            }
            if (comboBox2.SelectedIndex == 1 && textBox1.Text.Length > 0)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 10);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 8);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text, 2), 16);
            }
            if (comboBox2.SelectedIndex == 2 && textBox1.Text.Length > 0)
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
                label1.Text = myCollection[0];
                label2.Text = myCollection[1];
                label3.Text = myCollection[2];
                label4.Text = myCollection[3];

            } 
            else if (comboBox2.SelectedIndex == 1)
            {
                label1.Text = myCollection[1];
                label2.Text = myCollection[0];
                label3.Text = myCollection[2];
                label4.Text = myCollection[3];

            }
            else if (comboBox2.SelectedIndex == 2)
            {
                label1.Text = myCollection[2];
                label2.Text = myCollection[0];
                label3.Text = myCollection[1];
                label4.Text = myCollection[3];

            }
            else if (comboBox2.SelectedIndex == 3)
            {
                label1.Text = myCollection[3];
                label2.Text = myCollection[0];
                label3.Text = myCollection[1];
                label4.Text = myCollection[2];
            }
            foreach(Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (comboBox2.SelectedIndex == 1)
            {
                e.Handled = !Binary.Contains((Keys)e.KeyChar);
            } 

            if (comboBox2.SelectedIndex == 2)
            {
                e.Handled = !Octal.Contains((Keys)e.KeyChar);
            } 
            
            if (comboBox2.SelectedIndex == 3)
            {
                if (!Hexadecimal.Contains(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

    }
}
