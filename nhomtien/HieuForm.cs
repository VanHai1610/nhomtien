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
    public partial class HieuForm : Form
    {
        internal string[] myCollection = new string[] { "Decimal", "Binary", "Octal", "Hexadecimon" };
        public HieuForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                textBox2.Text = Convert.ToString(Convert.ToInt32( textBox1.Text), 2);
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 8);
                textBox4.Text = Convert.ToString(Convert.ToInt32(textBox1.Text), 16);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label1.Text = myCollection[1];
                label2.Text = myCollection[2];
                label3.Text = myCollection[3];

            } 
            if (comboBox2.SelectedIndex == 1)
            {
                label1.Text = myCollection[0];
                label2.Text = myCollection[2];
                label3.Text = myCollection[3];

            }
            if (comboBox2.SelectedIndex == 2)
            {
                label1.Text = myCollection[0];
                label2.Text = myCollection[1];
                label3.Text = myCollection[3];

            }
            if (comboBox2.SelectedIndex == 3)
            {
                label1.Text = myCollection[0];
                label2.Text = myCollection[1];
                label3.Text = myCollection[2];

            }

        }
    }
}
