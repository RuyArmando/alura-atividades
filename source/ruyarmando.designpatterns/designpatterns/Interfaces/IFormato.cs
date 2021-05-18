using designpatterns.Enums;
using designpatterns.Models;

namespace designpatterns.Interfaces
{
    public interface IFormato
    {
        IFormato Proximo { get; set; }
        string Converter(ContaBancaria conta, Requisicao requisicao);
    }
}
