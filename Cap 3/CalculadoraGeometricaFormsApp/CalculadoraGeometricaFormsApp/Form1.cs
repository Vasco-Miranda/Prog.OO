namespace CalculadoraGeometricaFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBut_Click(object sender, EventArgs e)
        {
            if (double.TryParse(larguraTB.Text, out double largura) && 
                double.TryParse(alturaTB.Text, out double altura) && 
                double.TryParse(raioTB.Text, out double raio))
            {
                GeometriaUtils.CalcularRetangulo(altura, largura,
                    out double area, out double perimetro);

                Circulo circulo = new Circulo(raio);

                logTB.Text += $"Criado círculo com raio {circulo.raio}. " + 
                    $"A área do retângulo é {area} e o perímetro é {perimetro}. \n";
            } else
            {
                logTB.Text += "Valores inválidos. \n";
            }

            alturaTB.Text = "";
            larguraTB.Text = "";
            raioTB.Text = "";
        }
    }
}
