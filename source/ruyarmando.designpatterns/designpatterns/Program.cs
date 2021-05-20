using designpatterns.Enums;
using designpatterns.Helpers;
using designpatterns.Models;
using System;
using System.Collections.Generic;

namespace designpatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaBancaria>
            {
                new ContaBancaria("7735-0", "000123456-X", "Fulano de Tal", 1580),
                new ContaBancaria("8846-2", "000456789-0", "Beltrano", 1000),
                new ContaBancaria("9957-8", "000789123-5", "Sicrano", 18000)
            };

            var relatorioSimples = new RelatorioSimples();
            relatorioSimples.Impirmir(contas);

            var relatorioComplexo = new RelatorioComplexo();
            relatorioComplexo.Impirmir(contas);

            Console.ReadKey();
        }
    }
}
