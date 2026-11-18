using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagerFormsApp
{
    enum TipoQuarto
    {
        Standard = 1,
        Twin = 2,
        Double = 3,
        Suite = 5,

    }

    internal class HotelRoom
    {
        private short numQuarto;
        private TipoQuarto tipo;
        private bool ocupado;
        private readonly double precoBase;

        private static short count = 0;
        private static short numQuartosOcupados = 0;
        private static double receitaAcumulada = 0.0;

        public HotelRoom(TipoQuarto tipo, double precoBase) 
        {
            count++;
            this.numQuarto = count;
            this.tipo = tipo;
            this.precoBase = precoBase;
            this.ocupado = false;
        }

        public HotelRoom(): this(TipoQuarto.Standard, 50.0) { }

        

    }


}
