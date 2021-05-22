using System.Collections.Generic;

namespace designpatterns.Models
{
    public abstract class Filtro
    {
        private readonly Filtro _outroFiltro;

        public Filtro(Filtro outroFiltro)
        {
            _outroFiltro = outroFiltro;
        }

        // construtor default
        public Filtro()
        {
            _outroFiltro = null;
        }

        public abstract IList<ContaBancaria> Filtra(IList<ContaBancaria> contas);

        protected IList<ContaBancaria> FiltraDoOutroFiltro(IList<ContaBancaria> contas)
        {
            // tratando o caso do proximo não existir
            if (_outroFiltro != null)
                return _outroFiltro.Filtra(contas);
            else
                return null;
        }
    }
}
