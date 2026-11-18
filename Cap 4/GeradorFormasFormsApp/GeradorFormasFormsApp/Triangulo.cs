using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorFormasFormsApp
{
    internal class Triangulo: Forma
    {
        public Triangulo() { }

        public override string Desenhar()
        {
            return Forma.desenho + "triângulo.\n";
        }

        public override string Apagar()
        {
            return Forma.apaga + "triângulo.\n";
        }
    }
}
