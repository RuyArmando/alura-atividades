using System;

namespace designpatterns.Models
{
    public class ContaBancaria
    {
        public ContaBancaria(string agencia, string numero, string titular, DateTime abertura, double saldo)
        {
            Agencia = agencia;
            Numero = numero;
            Titular = titular;
            Abertura = abertura;
            Saldo = saldo;
        }


        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public DateTime Abertura { get; private set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}