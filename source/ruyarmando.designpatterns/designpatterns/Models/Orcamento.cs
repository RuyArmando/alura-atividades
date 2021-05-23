using designpatterns.Interfaces;
using System;
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
            EstadoAtual = new EmAprovacao();
        }

        public double Valor { get; set; }
        public IEstadoDeUmOrcamento EstadoAtual { get; set; }

        public IReadOnlyCollection<Item> Itens { get { return itens.ToList(); } }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }
    }
}
