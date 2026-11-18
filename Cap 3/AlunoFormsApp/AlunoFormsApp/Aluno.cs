using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace AlunoFormsApp
{
    internal class Aluno
    {
        private static string dirTIC = "TBD";

        private string nome;
        private int idade;
        private string curso;
        private int ano;

        public Aluno() : this ("Sem nome")
        {

        }

        public Aluno(string nome)
        {
            this.nome = nome;
            this.curso = "";

            exibirCalendario();
        }

        public Aluno(string nome, int idade, string curso, int ano) : this(nome)
        {
            this.ano = ano;
            this.idade = idade;
            this.curso = curso;
        }
        

        public string getNome()
        {
            return nome;
        }

        public string getCurso()
        {
            return curso;
        }

        public int getIdade()
        {
            return idade;
        }

        public int getAno()
        {
            return ano;
        }

        private void exibirCalendario()
        {
            string msg = "";
            if (ano >= 0)
            {
                Calendario cal = new Calendario();
                if (ano == 1)
                {
                    msg += "Data de início: " + cal.getDataInicioAno1() + "; ";
                }
                else
                {
                    msg += "Data de início: " + cal.getDataInicioOutrosAnos() + "; ";
                }

                msg += "Data de fim: " + cal.getDataFimAno() + ". \n";
            }
            MessageBox.Show(msg);
        }

        public void MostrarDiretor()
        {
            if (curso == "TIC")
                MessageBox.Show($"O Diretor do curso de TIC é {dirTIC}");
            else
                MessageBox.Show("Diretor não definido");
        }

        public static void SetDiretor(string diretor)
        {
            dirTIC = diretor;
        }
    }
}
