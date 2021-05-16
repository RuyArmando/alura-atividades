namespace designpatterns.Models
{
    public class ContaBancaria
    {
        public ContaBancaria(double saldo)
        {
            Saldo = saldo;
        }

        public double Saldo { get; private set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}