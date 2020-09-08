using System;
using System.Globalization;

namespace ATV_COM_2_07._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();

            Console.Write("Informe seu nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Informe seu salário: ");
            a.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do imposto: ");
            a.Imposto = double.Parse(Console.ReadLine());

            double L = a.SalarioLiquido();
            Console.WriteLine("Funcionario: " + a.Nome + ", Salário: " + L.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Porcentagem de aumento?");
            double p = a.AumentarSalario(double.Parse(Console.ReadLine()));
            L = L + p;
            Console.WriteLine("Dados atualizados: " + a.Nome + ", R$" + L.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
