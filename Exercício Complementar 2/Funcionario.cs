using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_COM_2_07._09._2020
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double valor = SalarioBruto - Imposto;
            return valor;
        }

        public double AumentarSalario(double porcentagem)
        {
            double valor = (SalarioBruto * porcentagem) / 100;
            return valor;
        }
    }
}
