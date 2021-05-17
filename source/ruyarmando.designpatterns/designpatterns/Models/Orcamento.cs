using System.Collections.Generic;
using System.Linq;

namespace designpatterns.Models
{
    public class Orcamento
    {
        private readonly IList<Item> itens;

        public Orcamento(double valor)
        {
            Valor = valor;
            itens = new List<Item>();
        }

        public double Valor { get; private set; }

        public IReadOnlyCollection<Item> Itens { get { return itens.ToList(); } }

        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }
    }
}
