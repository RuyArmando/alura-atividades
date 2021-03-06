using designpatterns.Interfaces;

namespace designpatterns.Models
{
    public class ISS : Imposto
    {
        public ISS() : base(){}

        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            // ISS deve ser 6% do valor do orçamento
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
