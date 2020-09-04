using System;
using System.Security.Cryptography.X509Certificates;

namespace POO_ATV1_26._08._2020
{
    class Program
    {      
        static void Main(string[] args)
        {
            Pessoas pessoa1, pessoa2;

            pessoa1 = new Pessoas();
            pessoa2 = new Pessoas();

            Console.WriteLine("Dados 1° Pessoa: ");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados 1° Pessoa: ");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa1.idade > pessoa2.idade) //Comparação da idade das duas pessoas
            {
                Console.WriteLine(pessoa1.nome + " é mais velho(a)");
            }
            else
            {
                Console.WriteLine(pessoa2.nome + " é mais velho(a)");
            }            

            //Não coloquei na classe Pessoas pq não sabia como trazer de lá para cá

            Console.ReadKey();
        }
    }
}
