using System;
using System.Collections.Generic;
using System.Text;

namespace ContasBancoFormsApp
{
    internal class ContaBase
    {
        private const long NUMERO_CONTA_MIN = 800001;
        private const long NUMERO_CONTA_MAX = 1600000;
        private static long NUMERO_CONTA = NUMERO_CONTA_MIN;

        protected string subscritor;
        protected double saldo;
        protected long numeroConta;

        protected ContaBase(string subscritor, double saldo) { 
            this.subscritor = subscritor;
            this.saldo = saldo;
            this.numeroConta = NUMERO_CONTA;

            ContaBase.NUMERO_CONTA++;
        }


        public double Saldo { 
            get
            {
                return this.saldo;
            }
        }

        public string Subscritor { 
            get
            {  
                return this.subscritor; 
            }
        }

        public virtual void AddSaldo(double val)
        {
            saldo += val;
        }

        public virtual bool LevantarSaldo(double val) 
        {
            if (saldo < val)
                return false;

            saldo -= val;
            return true;
        }


    }
}
