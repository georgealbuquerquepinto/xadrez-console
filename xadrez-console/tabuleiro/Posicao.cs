﻿using System;

namespace xadrez_console.tabuleiro
{
    public class Posicao
    {
        public Posicao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public int linha { get; set; }
        public int coluna { get; set; }

        public override string ToString()
        {
            return linha + ", " + coluna;
        }
    }
}
