using designpatterns.Interfaces;
using designpatterns.Models;
using designpatterns.Models.Requisicoes;

namespace designpatterns.Helpers
{
    public class ExportarContaBancaria
    {
        public string Exportar(ContaBancaria conta, Requisicao requisicao)
        {
            IFormato r3 = new Porcento(null);
            IFormato r2 = new XML(r3);
            IFormato r1 = new CSV(r2);

            return r1.Converter(conta, requisicao) ?? "O formato informado é inválido!";
        }
    }
}
