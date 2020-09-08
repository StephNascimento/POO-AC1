using System;
using System.Globalization;

namespace ATV_COM_07._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Medidas x = new Medidas();

            Console.Write("Coloque a altura do retângulo: ");
            x.altura = double.Parse(Console.ReadLine());
            Console.Write("Coloque a largura do retângulo: ");
            x.largura = double.Parse(Console.ReadLine());

            double d = (x.altura * x.altura) + (x.largura * x.largura);
            d = Math.Sqrt(d);

            Console.WriteLine("Área: " + x.altura * x.largura);
            Console.WriteLine("Perímetro: " + ((2 * x.altura) + (2 * x.largura)));
            Console.WriteLine("Diagonal: " + d);

            Console.ReadKey();
        }
    }
}
