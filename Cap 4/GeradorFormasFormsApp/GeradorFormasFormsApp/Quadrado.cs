using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorFormasFormsApp
{
    internal class Quadrado: Forma
    {
        public Quadrado() { }

        public override string Desenhar()
        {
            return Forma.desenho + "quadrado.\n";
        }

        public override string Apagar()
        {
            return Forma.apaga + "quadrado.\n";
        }
    }
}
