using designpatterns.Interfaces;
using designpatterns.Models;
using System.Collections.Generic;

namespace designpatterns.Helpers
{
    public class ImprimirRelatorio
    {
        public void Imprimir(List<ContaBancaria> contas, TipoRelatorio tipo)
        {
            IRelatorio complex = new RelatorioComplexo();
            IRelatorio simples = new RelatorioSimples();

            simples.SetNext(complex);
            simples.Imprimir(contas, tipo);
        }
    }
}
