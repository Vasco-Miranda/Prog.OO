using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorFormasFormsApp
{
    internal class Circulo: Forma
    {
        public Circulo() { }

        public override string Desenhar()
        {
            return Forma.desenho + "círculo.\n";
        }

        public override string Apagar()
        {
            return Forma.apaga + "círculo.\n";
        }
    }
}
