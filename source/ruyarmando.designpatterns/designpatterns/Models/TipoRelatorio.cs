using designpatterns.Enums;

namespace designpatterns.Models
{
    public class TipoRelatorio
    {
        public ETipoRelatorio Tipo { get; private set; }

        public TipoRelatorio(ETipoRelatorio tipo)
        {
            Tipo = tipo;
        }
    }
}
