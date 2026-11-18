namespace AlunoFormsApp
{
    public partial class Form1 : Form
    {
        private Aluno[] alunos = new Aluno[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void criarAlunoBut_Click(object sender, EventArgs e)
        {
            if (nomeTB.Text.Length == 0 || idadeTB.Text.Length == 0 ||
                cursoTB.Text.Length == 0 || anoTB.Text.Length == 0)
            {
                return;
            }

            string nome = nomeTB.Text;
            string curso = cursoTB.Text;

            if (!int.TryParse(idadeTB.Text, out int idade))
            {
                return;
            }
            if (!int.TryParse(anoTB.Text, out int ano))
            {
                return;
            }

            Aluno newAluno = new Aluno(nome, idade, curso, ano);

            logTB.Text += $"Novo aluno criado - nome: {newAluno.getNome()}, " +
                $"idade: {newAluno.getIdade()}, curso: {newAluno.getCurso()}, " +
                $"ano: {newAluno.getAno()} \n";

            newAluno.MostrarDiretor();
            addAluno(newAluno);
        }

        private void dirBut_Click(object sender, EventArgs e)
        {
            if (nomeDirTB.Text.Length == 0)
                return;

            Aluno.SetDiretor(nomeDirTB.Text);
            nomeDirTB.Text = "";
        }

        private void addAluno(Aluno aluno)
        {

            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[i] == null)
                {
                    alunos[i] = aluno;
                    return;
                }
            }

            Array.Resize(ref alunos, alunos.Length + 10);

        }

        private void mostrarDirBut_Click(object sender, EventArgs e)
        {
            foreach (var a in alunos)
            {
                if (a == null)
                    return;
                MessageBox.Show($"A mostrar o Diretor do aluno {a.getNome()}");
                a.MostrarDiretor();
            }
        }
    }
}
