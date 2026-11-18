using System;
using System.Collections.Generic;
using System.Text;

namespace GeradorFormasFormsApp
{
    internal class GeradorAleatorioFormas
    {
        private Random rd;

        public GeradorAleatorioFormas()
        {
            rd = new Random();
        }

        public Forma GerarForma()
        {
            Forma forma;
            int i = rd.Next(1,4);

            switch (i)
            {
                case 1: 
                    forma = new Triangulo();
                    return forma;

                case 2:
                    forma = new Quadrado();
                    return forma;

                default:
                    forma = new Circulo();
                    return forma;
            }
        }
        

        public Forma[] GerarNFormas(int num = 9)
        {
            Forma[] arr = new Forma[num];

            for (int i = 0; i < num; i++) 
            {
                arr[i] = GerarForma();
            }

            return arr;
        }
    }
}
