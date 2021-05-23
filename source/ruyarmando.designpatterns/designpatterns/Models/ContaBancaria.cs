using designpatterns.Interfaces;
using System;

namespace designpatterns.Models
{
    public class ContaBancaria
    {
        private IEstodoDeUmaConta EstadoAtual;

        public ContaBancaria(string agencia, string numero, string titular, DateTime abertura, double saldo)
        {
            EstadoAtual = new Positivo();
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

        public void Deposito(double valor)
        {
            EstadoAtual.Deposito(this, valor);
        }

        public void Saque(double valor)
        {
            EstadoAtual.Saque(this, valor);
        }

        class Positivo : IEstodoDeUmaConta
        {
            public void Deposito(ContaBancaria conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Saque(ContaBancaria conta, double valor)
            {
                conta.Saldo -= valor;

                if (conta.Saldo < 0) conta.EstadoAtual = new Negativo();
            }
        }

        class Negativo : IEstodoDeUmaConta
        {
            public void Deposito(ContaBancaria conta, double valor)
            {
                conta.Saldo += valor * 0.95;
                if (conta.Saldo > 0) conta.EstadoAtual = new Positivo();
            }

            public void Saque(ContaBancaria conta, double valor)
            {
                throw new Exception($"Não foi possível realizar sua transação. Saldo negativo. Saldo: {conta.Saldo.ToString("C2")}");
            }
        }
    }
}