using designpatterns.Interfaces;

namespace designpatterns.Models.Requisicoes
{
    public class Invalido : IFormato
    {
        public IFormato Proximo { get; set; }

        public string Converter(ContaBancaria conta, Requisicao requisicao)
        {
            return "O formato informado é inválido!";
        }
    }
}
