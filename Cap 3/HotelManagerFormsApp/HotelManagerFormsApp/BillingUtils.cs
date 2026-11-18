using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagerFormsApp
{
    internal class BillingUtils
    {
        public static double CalcularPrecoEstadia(int dias, double preco, out double valorImpostos)
        {
            double precoEstadia = dias * preco;
            valorImpostos = precoEstadia * 0.23;
            return precoEstadia + valorImpostos;
        }
    }
}
