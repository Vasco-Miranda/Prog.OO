using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagerFormsApp
{
    internal class LibraryUtils
    {
        public static void CalculaTempoLeitura(int numPags, out int tempoEstimadoHoras)
        {
            tempoEstimadoHoras = (int) Math.Round(numPags * 0.05);
        }

        public static void ComportamentoRefTypes(Book b1)
        {
            MessageBox.Show($"Livro b1 tem autor {b1.GetAutor()}.");
            Book b2 = b1;
            MessageBox.Show("A alterar o autor do livro b2.");
            b2.SetAutor("José Saramago");
            MessageBox.Show($"Autor do livro b2 é agora {b2.GetAutor()}, e " +
                $"do livro b1 é {b1.GetAutor()}.");
        }

        public static Book FindBookByTitle(List<Book> books, string titulo)
        {
            foreach (Book book in books)
            {
                if (book.GetTitulo() == titulo)
                {
                    return book;
                    
                }
            }
            throw new Exception("Book not found");
        }
    }
}
