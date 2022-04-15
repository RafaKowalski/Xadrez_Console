using System;
using tabuleiro;

namespace tabuleiro.xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        {
            //peças brancas
            Tab.colocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('a',1).toPosicao());
            Tab.colocarPeca(new Cavalo(Cor.Branca, Tab), new PosicaoXadrez('b', 1).toPosicao());
            Tab.colocarPeca(new Bispo(Cor.Branca, Tab), new PosicaoXadrez('c', 1).toPosicao());
            Tab.colocarPeca(new Rei(Cor.Branca, Tab), new PosicaoXadrez('d', 1).toPosicao());
            Tab.colocarPeca(new Dama(Cor.Branca, Tab), new PosicaoXadrez('e', 1).toPosicao());
            Tab.colocarPeca(new Bispo(Cor.Branca, Tab), new PosicaoXadrez('f', 1).toPosicao());
            Tab.colocarPeca(new Cavalo(Cor.Branca, Tab), new PosicaoXadrez('g', 1).toPosicao());
            Tab.colocarPeca(new Torre(Cor.Branca, Tab), new PosicaoXadrez('h', 1).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('a', 2).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('b', 2).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('c', 2).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('d', 2).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('e', 2).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('f', 2).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('g', 2).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Branca, Tab), new PosicaoXadrez('h', 2).toPosicao());

            //pecas pretas
            Tab.colocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('a', 8).toPosicao());
            Tab.colocarPeca(new Cavalo(Cor.Preta, Tab), new PosicaoXadrez('b', 8).toPosicao());
            Tab.colocarPeca(new Bispo(Cor.Preta, Tab), new PosicaoXadrez('c', 8).toPosicao());
            Tab.colocarPeca(new Rei(Cor.Preta, Tab), new PosicaoXadrez('d', 8).toPosicao());
            Tab.colocarPeca(new Dama(Cor.Preta, Tab), new PosicaoXadrez('e', 8).toPosicao());
            Tab.colocarPeca(new Bispo(Cor.Preta, Tab), new PosicaoXadrez('f', 8).toPosicao());
            Tab.colocarPeca(new Cavalo(Cor.Preta, Tab), new PosicaoXadrez('g', 8).toPosicao());
            Tab.colocarPeca(new Torre(Cor.Preta, Tab), new PosicaoXadrez('h', 8).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('a', 7).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('b', 7).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('c', 7).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('d', 7).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('e', 7).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('f', 7).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('g', 7).toPosicao());
            Tab.colocarPeca(new Peao(Cor.Preta, Tab), new PosicaoXadrez('h', 7).toPosicao());
        }
    }
}
