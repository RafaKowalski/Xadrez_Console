using tabuleiro;

namespace tabuleiro.xadrez
{
    public class Bispo : Peca
    {
        public Bispo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "B";
        }

        public override bool[,] movimentosPossiveis()
        {
            return new bool[0, 0];
        }
    }
}
