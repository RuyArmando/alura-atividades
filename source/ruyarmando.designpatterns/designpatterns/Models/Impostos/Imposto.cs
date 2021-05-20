namespace designpatterns.Models
{
    public abstract class Imposto
    {
        private readonly Imposto _outroImposto;

        public Imposto(Imposto outroImposto)
        {
            _outroImposto = outroImposto;
        }

        // construtor default
        public Imposto()
        {
            _outroImposto = null;
        }

        public abstract double Calcula(Orcamento orcamento);

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            // tratando o caso do proximo imposto nao existir!
            return _outroImposto?.Calcula(orcamento) ?? 0;
        }
    }
}
