﻿using tabuleiro;

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
    }
}
