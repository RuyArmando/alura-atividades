using System.Collections.Generic;
using System.Linq;

namespace designpatterns.Models
{
    public class RelatorioSimples : TemplateDeRelatorio
    {
        protected override string Cabecalho()
        {
            return "BANCO IXARU S/A";
        }

        protected override string Corpo(IList<ContaBancaria> contas)
        {
            return string.Join("\n", contas.Select(s => $"Titular: {s.Titular} Saldo: {s.Saldo}"));
        }

        protected override string Rodape()
        {
            return "Telefone: (11) 3389-4128";
        }
    }
}
