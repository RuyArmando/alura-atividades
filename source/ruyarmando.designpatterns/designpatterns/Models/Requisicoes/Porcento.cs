using designpatterns.Enums;
using designpatterns.Interfaces;

namespace designpatterns.Models.Requisicoes
{
    public class Porcento : IFormato
    {
        public IFormato Proximo { get; set; }

        public string Converter(ContaBancaria conta, Requisicao requisicao)
        {
            if (requisicao.Formato == EFormato.PORCENTO)
                return $"{conta.Titular}%{conta.Saldo}";
            else
                return Proximo.Converter(conta, requisicao);
        }
    }
}
