using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagerFormsApp
{
    internal class Book
    {
        private string titulo;
        private string autor;
        private int numPags;

        public Book(string titulo, string autor, int numPags)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.numPags = numPags;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetAutor()
        {
            return autor;
        }

        public void SetAutor(string autor)
        {
            this.autor = autor;
        }

        public int GetNumPags()
        {
            return numPags;
        }

        public void SetNumPags(int numPags)
        {
            this.numPags = numPags;
        }

        public string Log()
        {
            return $"Criado um livro com título {titulo}, autor {autor} " + 
                $"e número de páginas {numPags}. \n";
        }
    }
}
