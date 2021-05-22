using System;
using System.Collections.Generic;
using System.Linq;

namespace designpatterns.Models
{
    public class ContaAberturaMesCorrente : Filtro
    {
        public ContaAberturaMesCorrente() { }

        public ContaAberturaMesCorrente(Filtro proximoFiltro) : base(proximoFiltro) { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            var retorno = contas
                .Where(w => w.Abertura.Year == DateTime.Now.Year && w.Abertura.Month == DateTime.Now.Month)
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
