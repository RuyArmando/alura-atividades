using designpatterns.Models;

namespace designpatterns.Interfaces
{
    public interface IDesconto
    {
        IDesconto Proximo { set; }
        double Desconta(Orcamento orcamento);
    }
}
