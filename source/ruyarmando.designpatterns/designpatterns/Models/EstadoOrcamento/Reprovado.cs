using designpatterns.Interfaces;
using System;

namespace designpatterns.Models
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento) => throw new Exception("O orçamento está reprovado, por esse motivo não é possível aplicar um desconto extra.");
        public void Aprova(Orcamento orcamento) => throw new Exception("O orçamento está reprovado, por esse motivo não pode ser aprovado.");
        public void Reprova(Orcamento orcamento) => throw new Exception("Orçamento já reprovado!");
        public void Finaliza(Orcamento orcamento) => orcamento.EstadoAtual = new Finalizado();
    }
}
