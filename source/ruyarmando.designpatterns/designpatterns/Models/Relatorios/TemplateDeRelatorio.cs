using System;
using System.Collections.Generic;
using System.Text;

namespace designpatterns.Models
{
    public abstract class TemplateDeRelatorio
    {
        public void Impirmir(IList<ContaBancaria> contas)
        {
            var retorno = new StringBuilder()
                .AppendLine(Cabecalho())
                .AppendLine(Corpo(contas))
                .AppendLine(Rodape());

            Console.WriteLine(retorno);
        }

        protected abstract string Cabecalho();
        protected abstract string Corpo(IList<ContaBancaria> contas);
        protected abstract string Rodape();
    }
}
