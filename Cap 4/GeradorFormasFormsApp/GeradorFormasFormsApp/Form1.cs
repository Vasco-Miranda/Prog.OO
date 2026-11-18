namespace GeradorFormasFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeradorAleatorioFormas gerador = new GeradorAleatorioFormas();

            Forma[] formas = gerador.GerarNFormas();

            foreach (Forma forma in formas)
            {
                outTb.Text += forma.Desenhar();
            }
        }
    }
}
