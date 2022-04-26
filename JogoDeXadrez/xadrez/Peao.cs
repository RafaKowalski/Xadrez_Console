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

        private bool existeInimigo (Posicao pos)
        {
            Peca peca = Tab.peca(pos);
            return peca != null && peca.Cor != Cor;
        }

        private bool livre(Posicao pos)
        {
            return Tab.peca(pos) == null;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos) && QteMovimentos == 0)
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;
            }
            else
            {
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos) && QteMovimentos == 0)
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}