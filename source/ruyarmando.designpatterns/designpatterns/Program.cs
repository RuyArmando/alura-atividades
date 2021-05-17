using designpatterns.Helpers;
using designpatterns.Models;
using System;

namespace designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculador = new CalculadorDeDescontos();

            var orcamento = new Orcamento(1500);

            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LÁPIS", 250.0));
            orcamento.AdicionaItem(new Item("CADERNO", 250.0));
            orcamento.AdicionaItem(new Item("ESTONJO", 250.0));
            orcamento.AdicionaItem(new Item("COLA", 250.0));
            orcamento.AdicionaItem(new Item("RÉGUA", 250.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine($"desconto condedido: {desconto.ToString("C2")}");
            Console.ReadKey();
        }
    }
}
