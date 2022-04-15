using tabuleiro;

namespace tabuleiro.xadrez
{
    public class Cavalo : Peca
    {
        public Cavalo(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        public override bool[,] movimentosPossiveis()
        {
            return new bool[0, 0];
        }
    }
}