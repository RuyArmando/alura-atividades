using designpatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace designpatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Filtro analise = new ContaAberturaMesCorrente(new ContaSaldoMaiorQueQuinhentosMil(new ContaSaldoMenorQueCem()));

            var contas = new List<ContaBancaria>()
            {
                new ContaBancaria("2877", "123456-7", "Fulano", DateTime.Now, 18000),
                new ContaBancaria("1562", "234567-8", "Beltrano", new DateTime(2015, 12, 25), 99.90),
                new ContaBancaria("0001", "345678-9", "Sicrano", new DateTime(2020, 08, 01), 500000.99),
                new ContaBancaria("0844", "456789-0", "Caio", new DateTime(2018, 05, 21), 500),
                new ContaBancaria("3356", "567890-1", "João", new DateTime(2018, 05, 21), 500)
            };

            var contasParaAnalise = analise.Filtra(contas);

            if (contasParaAnalise.Count > 0)
            {
                Console.WriteLine("Relação de contas encontrada para uma análise mais detalhada: ");
                Console.WriteLine(string.Join(Environment.NewLine, contasParaAnalise.Select(s => $"Titular: {s.Titular} Agência: {s.Agencia} Número da conta: {s.Numero} Saldo: {s.Saldo}")));
            }
            else
                Console.WriteLine("Nenhuma conta encontrada para uma análise mais detalhada!");

            Console.ReadKey();
        }
    }
}
