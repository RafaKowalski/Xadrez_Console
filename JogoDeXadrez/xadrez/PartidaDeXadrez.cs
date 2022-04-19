using System.Collections.Generic;
using tabuleiro;

namespace tabuleiro.xadrez
{
    public class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas;
        private HashSet<Peca> Capturadas;

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p, destino);
            if (pecaCapturada != null)
                Capturadas.Add(pecaCapturada);
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if (Tab.peca(pos) == null)
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");

            if (JogadorAtual != Tab.peca(pos).Cor)
                throw new TabuleiroException("A peça de origem não é sua!");

            if (!Tab.peca(pos).existeMovimentoPossiveis())
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.peca(origem).podeMoverPara(destino))
                throw new TabuleiroException("Posiçao de destino inválida!");
        }

        private void mudaJogador()
        {
            if (JogadorAtual == Cor.Branca)
                JogadorAtual = Cor.Preta;

            else
                JogadorAtual = Cor.Branca;
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            Turno++;
            mudaJogador();
        }

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Capturadas)
            {
                if (x.Cor== cor)
                    aux.Add(x);
            }
            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in Pecas)
            {
                if (x.Cor == cor)
                    aux.Add(x);
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            Pecas.Add(peca);
        }

        private void colocarPecas()
        {
            //pecas brancas
            colocarNovaPeca('c', 1, new Torre(Cor.Branca, Tab));
            colocarNovaPeca('c', 2, new Torre(Cor.Branca, Tab));
            colocarNovaPeca('d', 2, new Torre(Cor.Branca, Tab));
            colocarNovaPeca('e', 2, new Torre(Cor.Branca, Tab));
            colocarNovaPeca('e', 1, new Torre(Cor.Branca, Tab));
            colocarNovaPeca('d', 1, new Rei(Cor.Branca, Tab));

            //pecas pretas
            colocarNovaPeca('c', 7, new Torre(Cor.Preta, Tab));
            colocarNovaPeca('c', 8, new Torre(Cor.Preta, Tab));
            colocarNovaPeca('d', 7, new Torre(Cor.Preta, Tab));
            colocarNovaPeca('e', 7, new Torre(Cor.Preta, Tab));
            colocarNovaPeca('e', 8, new Torre(Cor.Preta, Tab));
            colocarNovaPeca('d', 8, new Rei(Cor.Preta, Tab));
        }
    }
}
