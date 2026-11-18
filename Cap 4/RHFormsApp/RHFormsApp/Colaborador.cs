using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RHFormsApp
{
    internal abstract class Colaborador
    {
        private const int SALARIO_MINIMO = 900;
        protected string _nome;
        protected double _salarioBase;
        protected int _codigoFuncionario;

        protected Colaborador(string nome, double salarioBase)
        {
            _nome = nome;
            if (ValidarSalarioBase(salarioBase))
                _salarioBase = salarioBase;
            else
                _salarioBase = SALARIO_MINIMO;
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        private bool ValidarSalarioBase(double salarioBase)
        {
            return salarioBase >= SALARIO_MINIMO;
        }

        protected int AuxGerarCodigoFuncionario(ref int currFuncionario)
        {
            int i = currFuncionario;
            currFuncionario++;
            return i;
        }

        public abstract double CalculaSalarioLiquido();

        public abstract int GerarCodigoFuncionario();
    }
}
