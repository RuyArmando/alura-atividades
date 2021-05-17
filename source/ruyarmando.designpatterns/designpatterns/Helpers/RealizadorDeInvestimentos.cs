using designpatterns.Interfaces;
using designpatterns.Models;
using System;

namespace designpatterns.Helpers
{
    public class RealizadorDeInvestimentos
    {
        public void Calcular(ContaBancaria conta, IInvestimento investimento)
        {
            var resultado = investimento.Calcular(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
