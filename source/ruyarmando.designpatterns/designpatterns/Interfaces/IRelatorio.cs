using designpatterns.Models;
using System.Collections.Generic;

namespace designpatterns.Interfaces
{
    public interface IRelatorio
    {
        IRelatorio SetNext(IRelatorio handler);

        void Imprimir(List<ContaBancaria> contas, TipoRelatorio tipo);
    }
}
