using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_COM3_07._09._2020
{
    class Notas
    {
        public string Nome;
        public int Nota1;
        public int Nota2;
        public int Nota3;

        public int SomaNotas()
        {
            int valor = Nota1 + Nota2 + Nota3;
            return valor;
        }

        public int Reprova()
        {
            int valor = Nota1 + Nota2 + Nota3;
            valor = 60 - valor;
            return valor;
        }
    }
}
