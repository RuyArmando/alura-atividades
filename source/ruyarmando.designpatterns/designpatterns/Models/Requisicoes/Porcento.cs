using designpatterns.Enums;
using designpatterns.Interfaces;

namespace designpatterns.Models.Requisicoes
{
    public class Porcento : IFormato
    {
        private readonly IFormato Proximo;

        public Porcento(IFormato formato)
        {
            Proximo = formato;
        }

        public string Converter(ContaBancaria conta, Requisicao requisicao)
        {
            if (requisicao.Formato == EFormato.PORCENTO)
                return $"{conta.Titular}%{conta.Saldo}";
            else
                return Proximo?.Converter(conta, requisicao);
        }
    }
}
