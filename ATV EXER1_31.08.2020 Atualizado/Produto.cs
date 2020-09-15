using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ATV_EXER1_31._08._2020
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotal()
        {
            double valor = Preco * Quantidade;
            return valor;
        }

        public void Adicionar(int quan)
        {
            Quantidade = Quantidade + quan;
        }

        public void Remover(int quan)
        {
            Quantidade = Quantidade - quan;
        }

        public override string ToString()
        {
            return Nome
            +", R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total R$"
            + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
