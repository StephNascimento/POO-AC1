using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ATV2_26._08._2020
{
    class Funcionario
    {
        public string nome;
        public double salario;

        public double Salario(Funcionario A, Funcionario B)
        {
            double M = (A.salario + B.salario) / 2;
            return M;
        }
    }
}
