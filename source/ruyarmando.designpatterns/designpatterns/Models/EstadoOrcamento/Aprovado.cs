using designpatterns.Interfaces;
using System;

namespace designpatterns.Models
{
    public class Aprovado : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (descontoAplicado)
                throw new Exception("Desconto extra já aplicado no orçamento!");

            orcamento.Valor -= orcamento.Valor * 0.02;
            descontoAplicado = true;
        }

        public void Aprova(Orcamento orcamento) => throw new Exception("Orçamento já aprovado!");
        public void Reprova(Orcamento orcamento) => throw new Exception("O orçamento está aprovado, por esse motivo não pode ser reprovado.");
        public void Finaliza(Orcamento orcamento) => orcamento.EstadoAtual = new Finalizado();
    }
}
