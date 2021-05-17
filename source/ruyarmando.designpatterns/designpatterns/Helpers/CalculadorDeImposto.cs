using designpatterns.Interfaces;
using designpatterns.Models;
using System;

namespace designpatterns.Helpers
{
    public class CalculadorDeImposto
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
