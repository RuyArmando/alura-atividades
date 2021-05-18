using designpatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace designpatterns.Models
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe(orcamento.Itens, "LAPIS") && Existe(orcamento.Itens, "CANETA"))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }

        private bool Existe(IEnumerable<Item> itens, string nomeDoItem)
        {
            return itens.Any(item => nomeDoItem.Equals(item.Nome));
        }
    }
}
