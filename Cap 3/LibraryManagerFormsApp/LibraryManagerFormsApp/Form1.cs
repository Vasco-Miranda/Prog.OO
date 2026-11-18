namespace LibraryManagerFormsApp
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void criarLivroBut_Click(object sender, EventArgs e)
        {
            if (tituloTB.Text == "" || autorTB.Text == "" || pagsTB.Text == "" ||
                !int.TryParse(pagsTB.Text, out int numPags) || numPags <= 0)
            {
                logTB.Text += "Tentativa de adicionar um livro com dados inválidos. \n";
                return;
            }

            Book newBook = new Book(tituloTB.Text, autorTB.Text, numPags);
            books.Add(newBook);

            logTB.Text += newBook.Log();

            LibraryUtils.ComportamentoRefTypes(newBook);
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            string titulo = searchTitleTB.Text;
            if (titulo == "")
            {
                logTB.Text += "Tentativa de requistar um livro com dados inválidos. \n";
                return;
            }

            try
            {
                Book found = LibraryUtils.FindBookByTitle(books, titulo);
                LibraryUtils.CalculaTempoLeitura(found.GetNumPags(), out int horas);

                logTB.Text += $"Livro {titulo} requisitado com sucesso. " + 
                    $"Tempo previsto de leitura é de {horas} horas. \n";

            } catch (Exception exp)
            {
                logTB.Text += $"Livro {titulo} não encontrado. \n";
            }
        }
    }
}
