namespace CalcEx5
{
    public partial class Form1 : Form
    {
        double a = -1;
        double b = -1;
        double total;

        Conta conta;

        enum Conta
        {
            Mais,
            Menos,
            Vezes,
            Dividir,
            Null
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            total = 0;
            a = -1;
            b = -1;
            conta = Conta.Null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            conta = Conta.Mais;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            conta = Conta.Menos;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            conta = Conta.Vezes;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            conta = Conta.Dividir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Text = "1";
            if (a == -1) { 
                a = 1;
            } else
            {
                b = 1;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Result.Text = "2";
            if (a == -1)
            {
                a = 2;
            }
            else
            {
                b = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result.Text = "3";
            if (a == -1)
            {
                a = 3;
            }
            else
            {
                b = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result.Text = "4";
            if (a == -1)
            {
                a = 4;
            }
            else
            {
                b = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Result.Text = "5";
            if (a == -1)
            {
                a = 5;
            }
            else
            {
                b = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result.Text = "6";
            if (a == -1)
            {
                a = 6;
            }
            else
            {
                b = 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Result.Text = "7";
            if (a == -1)
            {
                a = 7;
            }
            else
            {
                b = 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Result.Text = "8";
            if (a == -1)
            {
                a = 8;
            }
            else
            {
                b = 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Result.Text = "9";
            if (a == -1)
            {
                a = 9;
            }
            else
            {
                b = 9;
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch (conta)
            {
                case Conta.Mais:
                    total = a + b;
                    break;
                case Conta.Menos: 
                    total = a - b;
                    break;
                case Conta.Vezes:
                    total = a * b;
                    break;
                case Conta.Dividir:
                    total = a / b;
                    break;
                default:
                    break;
            }

            Result.Text = total.ToString();
        }
    }
}
