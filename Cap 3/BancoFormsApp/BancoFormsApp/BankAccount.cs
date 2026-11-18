using System;
using System.Collections.Generic;
using System.Text;

namespace BancoFormsApp
{
    internal class BankAccount
    {
        private string titular;
        private decimal saldo;

        public static decimal taxaManutencao = 0.25m;

        public BankAccount()
        {
            titular = "Desconhecido";
            saldo = 0.0m;
        }

        public BankAccount(string titular, decimal saldo)
        {
            this.titular = titular;
            this.saldo = saldo;
        }

        public static void AlterarTaxaManutenção(decimal novaTaxa) {
            taxaManutencao = novaTaxa;
        }

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetSaldo()
        {
            return saldo;
        }

        public void AdicionarSaldo(decimal valor)
        {
            saldo += valor;
        }

        public void RetirarSaldo(decimal valor)
        {
            saldo -= valor;
        }
    }
}
