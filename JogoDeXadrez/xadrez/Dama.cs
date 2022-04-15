using tabuleiro;

namespace tabuleiro.xadrez
{
    public class Dama : Peca
    {
        public Dama(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "D";
        }

        public override bool[,] movimentosPossiveis()
        {
            return new bool[0, 0];
        }
    }
}