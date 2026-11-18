namespace RHFormsApp
{
    public partial class Form1 : Form
    {
        Colaborador c;

        public Form1()
        {
            InitializeComponent();
        }

        private void progBut_Click(object sender, EventArgs e)
        {
            if (nomeTB.Text == "" || salarioTB.Text == "" || otherTB.Text == "")
            {
                outputTB.Text += "Campos não podem estar vazios. \n";
                return;
            }

            if (!Double.TryParse(salarioTB.Text, out double salarioBase))
            {
                outputTB.Text += "Salário base inválido. \n";
                return;
            }

            Programador p = new Programador(nomeTB.Text, salarioBase, otherTB.Text);
            c = p;

            outputTB.Text += $"Criado um Programador de nome {p.Nome}. \n";

        }

        private void gestorBut_Click(object sender, EventArgs e)
        {
            if (nomeTB.Text == "" || salarioTB.Text == "" || otherTB.Text == "")
            {
                outputTB.Text += "Campos não podem estar vazios. \n";
                return;
            }

            if (!Double.TryParse(salarioTB.Text, out double salarioBase))
            {
                outputTB.Text += "Salário base inválido. \n";
                return;
            }

            if (!uint.TryParse(otherTB.Text, out uint numEquipas))
            {
                outputTB.Text += "Número de equipas inválido. \n";
                return;
            }

            GestorProjeto gp = new GestorProjeto(nomeTB.Text, salarioBase, numEquipas);
            c = gp;

            outputTB.Text += $"Criado um Gestor de Projeto de nome {gp.Nome}. \n";
        }

        private void salarioBut_Click(object sender, EventArgs e)
        {
            outputTB.Text += $"O salário líquido do funcionário {c.Nome} é de " +
                $"{c.CalculaSalarioLiquido()}. \n";
        }
    }
}
