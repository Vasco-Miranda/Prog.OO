using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraGeometricaFormsApp
{
    internal class GeometriaUtils
    {
        public static void CalcularRetangulo(double altura, double largura,
            out double area, out double perimetro)
        {
            area = altura * largura;
            perimetro = (2 * altura) + (2 * largura);
        }
    }
}
