using designpatterns.Interfaces;
using System;

namespace designpatterns.Models
{
    public class CalculadorDeImposto
    {
        public void RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
