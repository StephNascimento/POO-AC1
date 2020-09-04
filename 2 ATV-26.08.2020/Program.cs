using System;
using System.Globalization;

namespace POO_ATV2_26._08._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario A, B;
            A = new Funcionario();
            B = new Funcionario();

            Console.WriteLine("Escreva seu nome e salário");
            Console.Write("Nome: ");
            A.nome = Console.ReadLine();
            Console.Write("Salário: ");
            A.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva seu nome e salário");
            Console.Write("Nome: ");
            B.nome = Console.ReadLine();
            Console.Write("Salário: ");
            B.salario = double.Parse(Console.ReadLine());                      

            Double M = (A.salario + B.salario) / 2;
            Console.WriteLine("Média salarial: " + M);

            if(A.salario > B.salario)
            {
                Console.WriteLine("Salário maior: " + A.nome);
            }
            else
            {
                Console.WriteLine("Salário maior: " + B.nome);
            }

            Console.ReadKey();
        }
    }
}
