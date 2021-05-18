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
            //var conta = new ContaBancaria("Fulado de Tal", 500);
            //var conversor = new ExportarContaBancaria();

            //var retono = conversor.Exportar(conta, new Requisicao(EFormato.XPTO));

            //Console.WriteLine($"XML: {conversor.Exportar(conta, new Requisicao(EFormato.XML))}");
            //Console.WriteLine($"CSV: {conversor.Exportar(conta, new Requisicao(EFormato.CSV))}");
            //Console.WriteLine($"Porcento: {conversor.Exportar(conta, new Requisicao(EFormato.PORCENTO))}");
            //Console.WriteLine($"XPTO: {conversor.Exportar(conta, new Requisicao(EFormato.XPTO))}");


            var calculador = new CalculadorDeDescontos();

            var orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("CADERNO", 250.0));

            double desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

            Console.ReadKey();
        }
    }
}
