using System.Diagnostics.Eventing.Reader;

namespace BancoFormsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> accounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void createBut_Click(object sender, EventArgs e)
        {
            BankAccount newAccount;

            if (nameTB.Text == "" && saldoTB.Text == "")
                newAccount = new BankAccount();
            else if (saldoTB.Text == "")
                newAccount = new BankAccount(nameTB.Text, 0.0m);
            else
            {
                if (decimal.TryParse(saldoTB.Text, out decimal saldo))
                {
                    newAccount = new BankAccount(nameTB.Text, saldo);
                }
                else
                {
                    logTB.Text += "Tentou criar uma conta com saldo inválido.\n";
                    return;
                }
            }
            accounts.Add(newAccount);

            logTB.Text += $"Criou uma nova conta com o titular {newAccount.GetTitular()} " +
                $"e o saldo {newAccount.GetSaldo()}. A taxa de manutenção é " +
                $"{BankAccount.taxaManutencao}. \n";

            nameTB.Text = "";
            saldoTB.Text = "";
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if (accounts.Count == 0)
            {
                logTB.Text += "Não existem contas para efetuar a operação. \n";
                valueTB.Text = "";
                return;
            }

            if (int.TryParse(valueTB.Text, out int value))
            {
                BankAccount lastAccount = accounts.Last();

                lastAccount.AdicionarSaldo(value);

                logTB.Text += $"{value} adicionado à conta com titular " +
                    $"{lastAccount.GetTitular()}. O saldo atual é de {lastAccount.GetSaldo()}. \n";
            }
            else
            {
                logTB.Text += "Saldo a adicionar inválido. \n";
            }

            valueTB.Text = "";
        }

        private void subBut_Click(object sender, EventArgs e)
        {
            if (accounts.Count == 0)
            {
                logTB.Text += "Não existem contas para efetuar a operação. \n";
                valueTB.Text = "";
                return;
            }

            if (int.TryParse(valueTB.Text, out int value))
            {
                BankAccount lastAccount = accounts.Last();

                lastAccount.RetirarSaldo(value);

                logTB.Text += $"{value} retirado à conta com titular " +
                    $"{lastAccount.GetTitular()}. O saldo atual é de {lastAccount.GetSaldo()}. \n";
            }
            else
            {
                logTB.Text += "Saldo a retirar inválido. \n";
            }

            valueTB.Text = "";
        }
    }
}
