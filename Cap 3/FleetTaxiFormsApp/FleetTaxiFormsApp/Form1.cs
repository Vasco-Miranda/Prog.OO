namespace FleetTaxiFormsApp
{
    public partial class Form1 : Form
    {
        List<FleetTaxi> frota = new List<FleetTaxi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            FleetTaxi f;
            if (matriculaTB.Text == "" || modeloTB.Text == "")
            {
                f = new FleetTaxi();
            } else
            {
                f = new FleetTaxi(matriculaTB.Text, modeloTB.Text);
            }
            
            frota.Add(f);
            logTB.Text += f.Log();
        }
    }
}
