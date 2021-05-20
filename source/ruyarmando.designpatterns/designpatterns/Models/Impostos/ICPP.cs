﻿namespace designpatterns.Models
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP() : base() { }

        public ICPP(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }
    }
}
