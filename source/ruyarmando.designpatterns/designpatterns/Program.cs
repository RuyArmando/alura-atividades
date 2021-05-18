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
            var conta = new ContaBancaria("Fulado de Tal", 500);
            var conversor = new ExportarContaBancaria();

            Console.WriteLine($"XML: {conversor.Exportar(conta, new Requisicao(EFormato.XML))}");
            Console.WriteLine($"CSV: {conversor.Exportar(conta, new Requisicao(EFormato.CSV))}");
            Console.WriteLine($"Porcento: {conversor.Exportar(conta, new Requisicao(EFormato.PORCENTO))}");
            Console.ReadKey();
        }
    }
}
