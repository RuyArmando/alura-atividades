using designpatterns.Models;

namespace designpatterns.Interfaces
{
    public interface IEstodoDeUmaConta
    {
        void Saque(ContaBancaria conta, double valor);
        void Deposito(ContaBancaria conta, double valor);
    }
}
