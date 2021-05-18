using designpatterns.Enums;

namespace designpatterns.Models
{
    public class Requisicao
    {
        public EFormato Formato { get; private set; }

        public Requisicao(EFormato formato)
        {
            Formato = formato;
        }
    }
}
