using designpatterns.Interfaces;
using System;

namespace designpatterns.Models.Investimentos
{
    public class Moderado : Investimento
    {
        private Random random;
        public Moderado()
        {
            random = new Random();
        }

        public double Calcular(ContaBancaria contaBancaria)
        {
            if (random.Next(2) == 0)
                return contaBancaria.Saldo * 0.025;
            else
                return contaBancaria.Saldo * 0.007;
        }
    }
}
