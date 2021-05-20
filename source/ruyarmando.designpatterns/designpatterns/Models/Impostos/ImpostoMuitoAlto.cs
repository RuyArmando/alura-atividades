namespace designpatterns.Models
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base() { }

        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
