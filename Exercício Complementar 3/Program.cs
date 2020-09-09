using System;

namespace ATV_COM3_07._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas a = new Notas();

            Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.Write("Qual a primeira nota do aluno? ");
            a.Nota1 = int.Parse(Console.ReadLine());
            Console.Write("Qual a segunda nota do aluno? ");
            a.Nota2 = int.Parse(Console.ReadLine());
            Console.Write("Qual a terceira nota do aluno? ");
            a.Nota3 = int.Parse(Console.ReadLine());

            int final = a.SomaNotas();
            int r = a.Reprova();
            Console.WriteLine("Nota Final: " + final);

            if (final > 60)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("Faltaram " + r + " pontos");
            }
            Console.ReadKey();
        }
    }
}
