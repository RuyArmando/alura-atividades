﻿using designpatterns.Interfaces;

namespace designpatterns.Models
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                //  5% do valor total caso o orçamento seja menor do que R$ 1000,00 reais
                return orcamento.Valor * 0.05;
            else if (orcamento.Valor >= 1000 && orcamento.Valor < 3000)
                // 7% caso o valor esteja entre R$ 1000 e R$ 3000,00
                return orcamento.Valor * 0.07;
            else
                // 8% mais 30 reais, caso o valor esteja acima de R$ 3000,00.
                return (orcamento.Valor * 0.08) + 30;
        }
    }
}
