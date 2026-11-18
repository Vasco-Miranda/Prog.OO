using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FleetTaxiFormsApp
{
    internal class FleetTaxi
    {
        private string matricula;
        private string modelo;
        private ushort noidu;
        private readonly decimal tarifa;

        private static ushort count = 0;

        public FleetTaxi(string matricula, string modelo)
        {
            this.matricula = matricula;
            this.modelo = modelo;
            this.tarifa = 7.5m;
            FleetTaxi.IncrementNoidu();
            this.noidu = (ushort) (10 + count);
        }

        public FleetTaxi(): this("00-AA-00", "undef") { }

        public static void IncrementNoidu() 
        {
            count++;
        }

        public static ushort getCount()
        {
            return count;
        }

        public string Log()
        {
            return $"Taxi criado com matrícula {matricula}, modelo {modelo} e " +
                $"número de ordem interno sequencial único {noidu}. " + 
                $"A tarifa de bandeirada é {tarifa}. Já foram criados {count} taxis. \n";
        }
        
    }
}
