using designpatterns.Models;

namespace designpatterns.Interfaces
{
    public interface IDesconto
    {
        IDesconto Proximo { get; set; }
        double Desconta(Orcamento orcamento);
    }
}
