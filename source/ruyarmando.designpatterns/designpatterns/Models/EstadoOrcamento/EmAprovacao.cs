using designpatterns.Interfaces;
using System;

namespace designpatterns.Models
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (descontoAplicado)
                throw new Exception("Desconto extra já aplicado no orçamento!");

            orcamento.Valor -= orcamento.Valor * 0.05;
            descontoAplicado = true;
        }

        public void Aprova(Orcamento orcamento) => orcamento.EstadoAtual = new Aprovado();
        public void Reprova(Orcamento orcamento) => orcamento.EstadoAtual = new Reprovado();
        public void Finaliza(Orcamento orcamento) => throw new Exception("O orçamento está em aprovação, por esse motivo não pode ser finalizado diretamente.");

    }
}
