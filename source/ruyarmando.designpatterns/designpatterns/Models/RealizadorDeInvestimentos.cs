using designpatterns.Interfaces;
using System;

namespace designpatterns.Models
{
    public class RealizadorDeInvestimentos
    {
        public void Calcular(ContaBancaria conta, Investimento investimento)
        {
            var resultado = investimento.Calcular(conta);
            conta.Deposita(resultado * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
