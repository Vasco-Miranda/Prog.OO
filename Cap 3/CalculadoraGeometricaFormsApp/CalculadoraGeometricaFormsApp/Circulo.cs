using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraGeometricaFormsApp
{
    internal class Circulo
    {
        public readonly double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public void AtualizarRaio(ref double raio)
        {
            this.raio = raio;
            raio = this.raio;
        }


    }
}
