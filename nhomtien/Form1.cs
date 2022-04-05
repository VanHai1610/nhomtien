namespace nhomtien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dec -> bin
            if (radioButton6.Checked == true)
            {
                int dec = Convert.ToInt32(textBox1.Text);
                if (dec == 0)
                    textBox2.Text = "0";
                else
                {
                    while (dec > 1)
                    {
                        int eec = dec % 2;
                        textBox2.Text = Convert.ToString(eec) + textBox2.Text;
                        dec = dec / 2;
                    }
                }
            }
            //bin -> dec
            double deci = 0;
            int a = 0;
            if (radioButton5.Checked == true)
            {
                int dec = Convert.ToInt32(textBox2.Text);
                while (dec >= 1)
                {
                    int eec2 = dec % 10;
                    deci = deci + eec2 * Math.Pow(2, a);
                    a++;
                    dec = dec / 10;
                    textBox1.Text = Convert.ToString(deci);
                }
            }
            //dec->otc
            if (radioButton3.Checked == true)
            {
                int dec = Convert.ToInt32(textBox1.Text);
                {
                    if (dec == 0)
                        textBox2.Text = "0";
                    else
                    {
                        while (dec > 1)
                        {
                            int otc = dec % 8;
                            textBox2.Text = Convert.ToString(otc) + textBox3.Text;
                            dec = dec / 8;
                        }
                    }
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
/*
            switch (op)
            {
                case 0:
                    if (D.Text == "0")
                        D.Text = "";
                    D.Text += FF;
                    DecimalATodo();
                    break;
                case 1:
                    if (B.Text == "0")
                        B.Text = "";
                    B.Text += FF;
                    BinarioATodo();
                    break;
                case 2:
                    if (O.Text == "0")
                        O.Text = "";
                    O.Text += FF;
                    OctalATodo();
                    break;
                case 3:
                    if (H.Text == "0")
                        H.Text = "";
                    H.Text += FF;
                    HexaATodo();
                    break;
            }
*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
 *   void DecimalABin() 
    {
        
        while (n != 0)
        {
            B.Text = (n % 2).ToString() + B.Text;
            n /= 2;
        }
    }
    void DecimalAOctal() 
    {
       
        while (n != 0)
        {
            O.Text = (n % 8).ToString() + O.Text;
            n /= 8;
        }
    }
  void BinADecimal()
        {
            n = 0;

            for (int x = B.Text.Length - 1, y = 0; x >= 0; x--, y++)
                n += (int)(int.Parse(B.Text[x].ToString()) * Math.Pow(2, y));
        }
        void OctalADecimal()
        {
            n = 0;
            for (int x = O.Text.Length - 1, y = 0; x >= 0; x--, y++)
                n += (int)(int.Parse(O.Text[x].ToString()) * Math.Pow(8, y));
        }
*/