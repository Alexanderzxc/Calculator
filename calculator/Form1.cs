namespace calculator
{
    public partial class Form1 : Form
    {
        int chislo;
        int number1;
        int number2;
        bool summ;
        bool min;
        bool umn;
        bool del;
        bool kor;
        bool kvadrat;
        double d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            chislo = Convert.ToInt32(textBox1.Text);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            chislo = Convert.ToInt32(textBox1.Text);
        }


        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number1 = chislo;
            summ = true;
            min = false;
            umn = false;
            kvadrat = false;
            kor = false;
            del = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number1 = chislo;
            summ = false;
            min = true;
            umn = false;
            kvadrat = false;
            kor = false;
            del = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number1 = chislo;
            summ = false;
            min = false;
            umn = true;
            kvadrat = false;
            kor = false;
            del = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number1 = chislo;
            summ = false;
            min = false;
            umn = false;
            kvadrat = false;
            kor = false;
            del = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(chislo * chislo);
            chislo = Convert.ToInt32(textBox1.Text);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Math.Sqrt(chislo));
            d = Math.Round(Convert.ToDouble(textBox1.Text));
            chislo = Convert.ToInt32(d);


        }

        private void button17_Click(object sender, EventArgs e)
        {
            int answer;
            if (summ == true)
            {
                answer = Convert.ToInt32(textBox1.Text) + number1;
                textBox1.Text = Convert.ToString(answer);
                chislo = Convert.ToInt32(textBox1.Text);
            }
            if (min == true)
            {
                answer = number1 - Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(answer);
                chislo = Convert.ToInt32(textBox1.Text);
            }
            if (umn == true)
            {
                answer = Convert.ToInt32(textBox1.Text) * number1;
                textBox1.Text = Convert.ToString(answer);
                chislo = Convert.ToInt32(textBox1.Text);
            }
            if (del == true)
            {
                answer = number1 / Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(answer);
                chislo = Convert.ToInt32(textBox1.Text);
            }


        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            chislo = Convert.ToInt32(textBox1.Text);
        }
    }
}