using System;
using System.Collections.Generic;
using System.Text;

namespace RHFormsApp
{
    internal class GestorProjeto: Colaborador
    {
        private static int currFuncionario = 5000;

        private const double BONUS_EQUIPA = 100;

        private uint _numEquipas;

        public GestorProjeto(string nome, double salarioBase,  uint numEquipas): base(nome, salarioBase)
        {
            _numEquipas = numEquipas;
            _codigoFuncionario = GerarCodigoFuncionario();
        }

        public override double CalculaSalarioLiquido()
        {
            return _salarioBase + (BONUS_EQUIPA * _numEquipas);
        }

        public override int GerarCodigoFuncionario()
        {
            return base.AuxGerarCodigoFuncionario(ref currFuncionario);
        }
    }
}
