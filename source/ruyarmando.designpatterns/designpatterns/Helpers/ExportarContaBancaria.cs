using designpatterns.Interfaces;
using designpatterns.Models;
using designpatterns.Models.Requisicoes;

namespace designpatterns.Helpers
{
    public class ExportarContaBancaria
    {
        public string Exportar(ContaBancaria conta, Requisicao requisicao)
        {
            IFormato r1 = new CSV();
            IFormato r2 = new XML();
            IFormato r3 = new Porcento();
            IFormato r4 = new Invalido();

            r1.Proximo = r2;
            r2.Proximo = r3;
            r3.Proximo = r4;

            return r1.Converter(conta, requisicao);
        }
    }
}
