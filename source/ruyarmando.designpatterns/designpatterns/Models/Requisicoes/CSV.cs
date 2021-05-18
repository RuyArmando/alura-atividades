using designpatterns.Enums;
using designpatterns.Interfaces;

namespace designpatterns.Models.Requisicoes
{
    public class CSV : IFormato
    {
        private readonly IFormato Proximo;

        public CSV(IFormato formato)
        {
            Proximo = formato;
        }

        public string Converter(ContaBancaria conta, Requisicao requisicao)
        {
            if (requisicao.Formato == EFormato.CSV)
                return $"{conta.Titular};{conta.Saldo};";
            else
                return Proximo?.Converter(conta, requisicao);
        }
    }
}
