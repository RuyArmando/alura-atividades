using designpatterns.Interfaces;
using System;

namespace designpatterns.Models.Investimentos
{
    public class Arrojado : Investimento
    {
        private Random random;

        public Arrojado()
        {
            random = new Random();
        }

        public double Calcular(ContaBancaria contaBancaria)
        {
            int chance = random.Next(10);

            if (chance >= 0 && chance <= 1)
                return contaBancaria.Saldo * 0.05;
            else if (chance >= 2 && chance <= 4)
                return contaBancaria.Saldo * 0.03;
            else
                return contaBancaria.Saldo * 0.006;
        }
    }
}
