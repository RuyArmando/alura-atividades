using designpatterns.Enums;
using designpatterns.Interfaces;

namespace designpatterns.Models
{
    public class XML : IFormato
    {
        private readonly IFormato Proximo;

        public XML(IFormato formato)
        {
            Proximo = formato;
        }

        public string Converter(ContaBancaria conta, Requisicao requisicao)
        {
            if (requisicao.Formato == EFormato.XML)
                return $"<conta><titular>{conta.Titular}</titular><saldo>{conta.Saldo}</saldo></conta>";
            else
                return Proximo?.Converter(conta, requisicao);
        }
    }
}
