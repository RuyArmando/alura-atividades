using designpatterns.Interfaces;
using System;

namespace designpatterns.Models.Investimentos
{
    public class Conservador : Investimento
    {
        public double Calcular(ContaBancaria contaBancaria)
        {
            return contaBancaria.Saldo * 0.008;
        }
    }
}
