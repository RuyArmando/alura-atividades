using designpatterns.Enums;
using designpatterns.Helpers;
using designpatterns.Models;
using System;

namespace designpatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculador = new CalculadorDeImposto();

            var orcamento = new Orcamento(100.0);
            orcamento.AdicionaItem(new Item("CANETA", 50.0));
            orcamento.AdicionaItem(new Item("CANETA", 50.0));

            Console.WriteLine($"IHIT: {calculador.RealizarCalculo(orcamento, new IHIT())}");
            Console.ReadKey();
        }
    }
}
