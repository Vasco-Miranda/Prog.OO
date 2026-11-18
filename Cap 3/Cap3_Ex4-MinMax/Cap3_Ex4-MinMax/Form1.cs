namespace Cap3_Ex4_MinMax
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtb1.TextChanged += InputTextBox_TextChanged;
            rtb2.TextChanged += InputTextBox_TextChanged;
        }

        private void butCalc_Click(object sender, EventArgs e)
        {
            MinMaxEnum type = MinMaxEnum.Max;
            if (min.Checked == true)
            {
                type = MinMaxEnum.Min;
            }

            MathUtils mathUtils = new MathUtils();
            int val = 0;

            if (!int.TryParse(rtb1.Text, out int a))
                return;

            if (!int.TryParse(rtb2.Text, out int b))
                return;

            if (!string.IsNullOrWhiteSpace(rtb3.Text))
            {
                if (!int.TryParse(rtb3.Text, out int c))
                    return;

                val = mathUtils.MinMax(a, b, c, type);
            } else
            {
                val = mathUtils.MinMax(a, b, type);
            }

            resultRTB.Text = val.ToString();
        }


        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            // Trim to avoid spaces-only input
            butCalc.Enabled = !string.IsNullOrWhiteSpace(rtb1.Text) &&
                !string.IsNullOrWhiteSpace(rtb2.Text);
        }
    }
}
