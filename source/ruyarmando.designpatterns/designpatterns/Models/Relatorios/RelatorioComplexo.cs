using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace designpatterns.Models
{
    public class RelatorioComplexo : TemplateDeRelatorio
    {
        protected override string Cabecalho()
        {
            return string.Concat("BANCO IXARU S/A"
                , "\r\nEndereço: Estrada do Sonho, 19.883 - Centro - São Paulo/SP"
                , "\r\nTelefone: (11) 3389-4128");
        }

        protected override string Corpo(IList<ContaBancaria> contas)
        {
            return string.Join("\r\n", contas.Select(s => $"Titular: {s.Titular} Agência: {s.Agencia} Número da conta: {s.Numero} Saldo: {s.Saldo}"));
        }

        protected override string Rodape()
        {
            return string.Concat("E-mail: contato@bancoixaru.com.br"
                , $"\r\nData Impressão: {DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")}");
        }
    }
}
