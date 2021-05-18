namespace designpatterns.Models
{
    public class ContaBancaria
    {
        public ContaBancaria(string titular, double saldo)
        {
            Saldo = saldo;
            Titular = titular;
        }

        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}