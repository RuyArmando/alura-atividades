using designpatterns.Enums;
using designpatterns.Models;

namespace designpatterns.Interfaces
{
    public interface IFormato
    {
        string Converter(ContaBancaria conta, Requisicao requisicao);
    }
}
