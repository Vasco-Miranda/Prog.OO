using System;
using System.Collections.Generic;
using System.Text;

namespace ContasBancoFormsApp
{
    internal class ContaOrdem: ContaBase
    {
        ContaOrdem(string subscritor, double saldo): base(subscritor, saldo) { }

        public string RequisitarLivroCheques()
        {
            // TODO lógica de requisição de livro de cheques
            return "Livro de cheques requisitado";
        }

    }
}
