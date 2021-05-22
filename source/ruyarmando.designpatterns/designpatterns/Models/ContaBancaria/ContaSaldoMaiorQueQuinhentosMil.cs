using System.Collections.Generic;
using System.Linq;

namespace designpatterns.Models
{
    public class ContaSaldoMaiorQueQuinhentosMil : Filtro
    {
        public ContaSaldoMaiorQueQuinhentosMil() { }

        public ContaSaldoMaiorQueQuinhentosMil(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            var retorno = contas
                .Where(w => w.Saldo > 500000)
                .ToList();

            var outrasContas = FiltraDoOutroFiltro(contas);

            if (outrasContas != null && outrasContas.Count > 0)
            {
                retorno.AddRange(outrasContas);
            }

            return retorno;
        }
    }
}
