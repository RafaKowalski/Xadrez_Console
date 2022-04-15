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

        public override bool[,] movimentosPossiveis()
        {
            return new bool[0, 0];
        }
    }
}