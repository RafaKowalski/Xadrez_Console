using tabuleiro;

namespace tabuleiro.xadrez
{
    public class Peao : Peca
    {

        private PartidaDeXadrez Partida;
        public Peao(Cor cor, Tabuleiro tab, PartidaDeXadrez partida) : base(cor, tab)
        {
            Partida = partida;
        }

        public override string ToString()
        {
            return "p";
        }

        private bool existeInimigo(Posicao pos)
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
                Posicao p2 = new Posicao(Posicao.Linha - 1, Posicao.Coluna);
                if (Tab.posicaoValida(p2) && livre(p2) && Tab.posicaoValida(pos) && livre(pos) && QteMovimentos == 0)
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;
            }

            // #jogadaespecial en passant
            /*if (Posicao.Linha == 3)
            {
                Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                if (Tab.posicaoValida(esquerda) && existeInimigo(esquerda) && Tab.peca(esquerda) == Partida.vulneralEnPassant)
                    mat[esquerda.Linha - 1, esquerda.Coluna] = true;

                Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                if (Tab.posicaoValida(direita) && existeInimigo(direita) && Tab.peca(direita) == Partida.vulneralEnPassant)
                    mat[direita.Linha - 1, direita.Coluna] = true;
            }*/


            else
            {
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.posicaoValida(pos) && livre(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha + 2, Posicao.Coluna);
                Posicao p2 = new Posicao(Posicao.Linha + 1, Posicao.Coluna);
                if (Tab.posicaoValida(p2) && livre(p2) && Tab.posicaoValida(pos) && livre(pos) && QteMovimentos == 0)
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tab.posicaoValida(pos) && existeInimigo(pos))
                    mat[pos.Linha, pos.Coluna] = true;

                // #jogadaespecial en passant
                /*if (Posicao.Linha == 4)
                {
                    Posicao esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    if (Tab.posicaoValida(esquerda) && existeInimigo(esquerda) && Tab.peca(esquerda) == Partida.vulneralEnPassant)
                        mat[esquerda.Linha + 1, esquerda.Coluna] = true;

                    Posicao direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    if (Tab.posicaoValida(direita) && existeInimigo(direita) && Tab.peca(direita) == Partida.vulneralEnPassant)
                        mat[direita.Linha + 1, direita.Coluna] = true;
                }*/
            }

            return mat;
        }
    }
}