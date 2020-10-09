using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
            this.partida = partida;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] tabuleiro = new bool[Tabuleiro.linhas, Tabuleiro.colunas];

            Posicao posicao;

            // norte
            posicao = new Posicao(Posicao.linha - 1, Posicao.coluna);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // nordeste
            posicao = new Posicao(Posicao.linha - 1, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // leste
            posicao = new Posicao(Posicao.linha, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // sudeste
            posicao = new Posicao(Posicao.linha + 1, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // sul
            posicao = new Posicao(Posicao.linha + 1, Posicao.coluna);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // suldoeste
            posicao = new Posicao(Posicao.linha + 1, Posicao.coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // oeste
            posicao = new Posicao(Posicao.linha, Posicao.coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // noroeste
            posicao = new Posicao(Posicao.linha - 1, Posicao.coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            // #JogadaEspecial (Roque)
            if (qtdMovimentos == 0 && !partida.xeque)
            {
                // #JogadaEspecial (Roque pequeno)
                Posicao posicaoTorre;
                
                posicaoTorre = new Posicao(Posicao.linha, Posicao.coluna + 3);

                if (testeTorreParaRoque(posicaoTorre))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna + 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna + 2);

                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null)
                    {
                        tabuleiro[Posicao.linha, Posicao.coluna + 2] = true;
                    }
                }

                // #JogadaEspecial (Roque grande)
                posicaoTorre = new Posicao(Posicao.linha, Posicao.coluna - 4);

                if (testeTorreParaRoque(posicaoTorre))
                {
                    Posicao p1 = new Posicao(Posicao.linha, Posicao.coluna - 1);
                    Posicao p2 = new Posicao(Posicao.linha, Posicao.coluna - 2);
                    Posicao p3 = new Posicao(Posicao.linha, Posicao.coluna - 3);

                    if (Tabuleiro.peca(p1) == null && Tabuleiro.peca(p2) == null && Tabuleiro.peca(p3) == null)
                    {
                        tabuleiro[Posicao.linha, Posicao.coluna - 2] = true;
                    }
                }
            }

            return tabuleiro;
        }

        private bool podeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.peca(posicao);

            return peca == null || peca.Cor != Cor;
        }

        private bool testeTorreParaRoque(Posicao posicao)
        {
            Peca peca = Tabuleiro.peca(posicao);

            return peca != null && peca is Torre && peca.Cor == Cor && peca.qtdMovimentos == 0;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
