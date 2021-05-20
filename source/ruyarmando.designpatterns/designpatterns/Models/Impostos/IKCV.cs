using System.Linq;

namespace designpatterns.Models
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV() : base() { }

        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && orcamento.Itens.Any(x => x.Valor > 100);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10 + CalculoDoOutroImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
