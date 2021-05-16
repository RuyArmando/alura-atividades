using designpatterns.Interfaces;
using designpatterns.Models;

namespace designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iccc = new ICCC();

            var orcamento = new Orcamento(3500.0);
            var calculador = new CalculadorDeImposto();

            // Calculando o ICCC    
            calculador.RealizarCalculo(orcamento, iccc);
        }
    }
}
