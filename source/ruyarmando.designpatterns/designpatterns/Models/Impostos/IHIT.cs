using System.Linq;

namespace designpatterns.Models
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ExisteItensComMesmoNome(orcamento);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (orcamento.Itens.Count * 0.01);
        }

        private bool ExisteItensComMesmoNome(Orcamento orcamento)
        {
            return orcamento.Itens
                .GroupBy(g => g.Nome)
                .Any(x => x.Count() > 1);
        }
    }
}
