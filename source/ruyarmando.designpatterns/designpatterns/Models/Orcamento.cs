namespace designpatterns.Models
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
        }

        public double Valor { get; private set; }
    }
}
