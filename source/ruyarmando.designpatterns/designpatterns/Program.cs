using designpatterns.Models;
using System;

namespace designpatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            Imposto ikcv = new IKCV(new ImpostoMuitoAlto());
            Imposto icpp = new ICPP(new ICMS());

            var orcamento = new Orcamento(500);

            var valorIKCV = ikcv.Calcula(orcamento);
            var valorICPP = icpp.Calcula(orcamento);

            Console.WriteLine(valorIKCV);
            Console.WriteLine(valorICPP);
            Console.ReadKey();
        }
    }
}
