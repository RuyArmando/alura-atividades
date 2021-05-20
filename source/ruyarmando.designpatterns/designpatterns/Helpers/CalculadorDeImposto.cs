using designpatterns.Interfaces;
using designpatterns.Models;
using System;

namespace designpatterns.Helpers
{
    public class CalculadorDeImposto
    {
        public double RealizarCalculo(Orcamento orcamento, Imposto imposto)
        {
            return imposto.Calcula(orcamento);
        }
    }
}
