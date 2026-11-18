using System;
using System.Collections.Generic;
using System.Text;

namespace RHFormsApp
{
    internal class Programador: Colaborador
    {
        private static int currFuncionario = 1000;

        private const double BONUS_PROD = 150;
        private string _linguagem;

        public Programador(string nome, double salarioBase, string linguagem): base(nome, salarioBase) 
        {
            _linguagem = linguagem;
            _codigoFuncionario = GerarCodigoFuncionario();

            MessageBox.Show($"Criado Programados com código de funcionário {_codigoFuncionario}");
        }

        public string Linguagem
        {
            get 
            { 
                return _linguagem; 
            } 
            set 
            { 
                _linguagem = value; 
            }
        }
        
        public override double CalculaSalarioLiquido()
        {
            return _salarioBase + BONUS_PROD;
        }

        public override int GerarCodigoFuncionario()
        {
            return base.AuxGerarCodigoFuncionario(ref currFuncionario);
        }
    }
}
