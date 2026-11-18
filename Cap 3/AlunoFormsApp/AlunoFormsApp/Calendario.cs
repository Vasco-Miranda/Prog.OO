using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoFormsApp
{
    internal class Calendario
    {
        private DateOnly dataInicioAno1;
        private DateOnly dataInicioOutrosAnos;
        private DateOnly dataFimAno;

        public Calendario()
        {
            dataInicioAno1 = new DateOnly(2009, 09, 21);
            dataInicioOutrosAnos = new DateOnly(2009, 09, 14);
            dataFimAno = new DateOnly(2010, 06, 4);
        }

        public void setDataInicioAno1(DateOnly dataInicioAno1)
        {
            this.dataInicioAno1 = dataInicioAno1;
        }

        public DateOnly getDataInicioAno1()
        {
            return dataInicioAno1;
        }

        public void setDataInicioOutrosAnos(DateOnly dataInicioOutrosAnos)
        {
            this.dataInicioOutrosAnos = dataInicioOutrosAnos;
        }

        public DateOnly getDataInicioOutrosAnos()
        {
            return dataInicioOutrosAnos;
        }

        public void setDataFimAno(DateOnly dataFimAno)
        {
            this.dataFimAno = dataFimAno;
        }

        public DateOnly getDataFimAno()
        {
            return dataFimAno;
        }
    }

}
