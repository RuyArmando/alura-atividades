using designpatterns.Interfaces;

namespace designpatterns.Models
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            // ICMS deve ser 5% do valor do orçamento mais o valor fixo de R$ 50,00
            return (orcamento.Valor * 0.5) + 50;
        }
    }
}
