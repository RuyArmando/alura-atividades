using designpatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace designpatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var conta = new ContaBancaria("2877", "123456-7", "Fulano", DateTime.Now, 100);

                conta.Saque(50);
                conta.Deposito(100);
                conta.Saque(150);
                conta.Deposito(20);
                conta.Saque(117);
                conta.Saque(10); // error
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            Console.ReadKey();
        }
    }
}
