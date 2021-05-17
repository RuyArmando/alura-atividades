using designpatterns.Interfaces;
using System;

namespace designpatterns.Models
{
    public class Conservador : IInvestimento
    {
        public double Calcular(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.008;
        }
    }
}
