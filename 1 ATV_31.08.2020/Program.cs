using System;
using System.Globalization;

namespace ATV_EXER1_31._08._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto a = new Produto();

            Console.WriteLine("Entre com os produtos: ");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            a.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            a.Quantidade = int.Parse(Console.ReadLine());
            double totalestoque = a.ValorTotal();

            Console.WriteLine("Dados do produto: " + a.Nome + ", R$" + a.Preco + ", " + a.Quantidade +
                ", unidades, total: R$" + totalestoque.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Digite o número a ser adicionado no estoque: ");
            a.Adicionar(int.Parse(Console.ReadLine()));
            totalestoque = a.ValorTotal();
            Console.WriteLine("Dados atualizados: " + a.Nome + ", R$" + a.Preco + ", " + a.Quantidade +
                " unidades, total: R$" + totalestoque.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Digite o número a ser removido no estoque: ");
            a.Remover(int.Parse(Console.ReadLine()));
            totalestoque = a.ValorTotal();

            Console.WriteLine("Dados atualizados: " + a.Nome + ", R$" + a.Preco + ", " + a.Quantidade +
                " unidades, total: R$" + totalestoque.ToString("F2", CultureInfo.InvariantCulture)) ;
            Console.ReadKey();
        }
    }
}
