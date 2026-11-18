namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Aluno alunoTrabalhadorEstudante;
        Aluno novoAluno;
        Disciplina lp = new Disciplina();

        enum Temperatura
        {
            Normal,
            Baixa,
            Alta

            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alunoTrabalhadorEstudante = new Aluno();
            alunoTrabalhadorEstudante.nome = "Teodoro Silva";

            novoAluno = new Aluno();
            novoAluno.nome = "Teodoro Costa da Silva";

            lp.nome = "Linguagens de Programação";
            lp.creditos = 5.5;
        }

        private void Mostrar(object umObjeto)
        {
            richTextBox.AppendText(umObjeto + "\n");
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void executar_Click(object sender, EventArgs e)
        {
            Mostrar(alunoTrabalhadorEstudante.nome);
            Mostrar(alunoTrabalhadorEstudante.numero);
        }
    }
}
