using designpatterns.Interfaces;

namespace designpatterns.Models
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            // ISS deve ser 6% do valor do orçamento
            return orcamento.Valor * 0.06;
        }
    }
}
