﻿using System;
using tabuleiro;
using tabuleiro.xadrez;

namespace xadrez_console
{
     public class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 7));
            tab.colocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(0, 1));
            tab.colocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(0, 6));
            tab.colocarPeca(new Bispo(Cor.Preta, tab), new Posicao(0, 2));
            tab.colocarPeca(new Bispo(Cor.Preta, tab), new Posicao(0, 5));
            tab.colocarPeca(new Dama(Cor.Preta, tab), new Posicao(0, 3));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 4));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 0));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 1));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 2));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 3));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 4));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 5));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 6));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(1, 7));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(7, 0));
            tab.colocarPeca(new Torre(Cor.Preta, tab), new Posicao(7, 7));
            tab.colocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(7, 1));
            tab.colocarPeca(new Cavalo(Cor.Preta, tab), new Posicao(7, 6));
            tab.colocarPeca(new Bispo(Cor.Preta, tab), new Posicao(7, 2));
            tab.colocarPeca(new Bispo(Cor.Preta, tab), new Posicao(7, 5));
            tab.colocarPeca(new Dama(Cor.Preta, tab), new Posicao(7, 3));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(7, 4));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 0));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 1));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 2));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 3));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 4));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 5));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 6));
            tab.colocarPeca(new Peao(Cor.Preta, tab), new Posicao(6, 7));


            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}