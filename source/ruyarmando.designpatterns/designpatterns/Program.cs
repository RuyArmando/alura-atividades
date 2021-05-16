using designpatterns.Interfaces;
using designpatterns.Models;

namespace designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            var orcamento = new Orcamento(500.0);
            var calculador = new CalculadorDeImposto();

            // Calculando o ISS
            calculador.RealizarCalculo(orcamento, iss);

            // Calculando o ICMS        
            calculador.RealizarCalculo(orcamento, icms);
        }
    }
}
