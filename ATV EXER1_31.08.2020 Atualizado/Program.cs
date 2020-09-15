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

            Console.WriteLine("Dados do produto: " + a);

            Console.Write("Digite o número a ser adicionado no estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            a.Adicionar(qtd);

            Console.WriteLine("Dados atualizados: " + a);

            Console.Write("Digite o número a ser removido no estoque: ");
            qtd = int.Parse(Console.ReadLine());
            a.Remover(qtd);

            Console.WriteLine("Dados atualizados: " + a) ;
            Console.ReadKey();
        }
    }
}
