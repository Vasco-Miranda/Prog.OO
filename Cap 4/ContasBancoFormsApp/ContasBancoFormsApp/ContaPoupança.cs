using System;
using System.Collections.Generic;
using System.Text;

namespace ContasBancoFormsApp
{
    internal class ContaPoupança: ContaBase
    {
        private const double JUROS_BAIXOS = 3.0;
        private const double JUROS_ALTOS = 6.0;

        private double juros;

        public ContaPoupança(string subscritor, double saldo): base(subscritor, saldo)
        {
            UpdateJuros();
        }

        private void UpdateJuros()
        {
            if (base.saldo <= 10000)
                juros = JUROS_BAIXOS;
            else
                juros = JUROS_ALTOS;
        }

        public override void AddSaldo(double val)
        {
            base.AddSaldo(val);
            UpdateJuros();
        }

        public override bool LevantarSaldo(double val)
        {
            if (base.LevantarSaldo(val))
            {
                UpdateJuros();
                return true;
            }
            return false;
            
        }

    }
}
