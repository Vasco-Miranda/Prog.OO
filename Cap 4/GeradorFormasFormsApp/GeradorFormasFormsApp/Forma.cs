using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;

namespace GeradorFormasFormsApp
{
    internal abstract class Forma
    {
        protected const string desenho = "A desenhar um ";
        protected const string apaga = "A apagar um ";
        protected Forma() { }

        public abstract string Desenhar();

        public abstract string Apagar();
    }
}
