using tabuleiro;

namespace tabuleiro.xadrez
{
    public class Peao : Peca
    {
        public Peao(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "p";
        }
    }
}