using tabuleiro;

namespace xadrez
{
    class Peao : Peca
    {
        private PartidaDeXadrez Partida;
        public Peao(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            Partida = partida;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] tabuleiro = new bool[Tabuleiro.linhas, Tabuleiro.colunas];

            Posicao posicao;

            if (Cor == Cor.Branca)
            {
                posicao = new Posicao(Posicao.linha - 1, Posicao.coluna);
                if (Tabuleiro.posicaoValida(posicao) && livre(posicao))
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                posicao = new Posicao(Posicao.linha - 2, Posicao.coluna);
                Posicao posicaoAux = new Posicao(Posicao.linha - 1, Posicao.coluna);
                if (Tabuleiro.posicaoValida(posicaoAux) && livre(posicaoAux) && Tabuleiro.posicaoValida(posicao) && livre(posicao) && qtdMovimentos == 0)
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                posicao = new Posicao(Posicao.linha - 1, Posicao.coluna - 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                posicao = new Posicao(Posicao.linha - 1, Posicao.coluna + 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                // #JogadaEspecial (En Passant)
                if (Posicao.linha == 3)
                {
                    Posicao esquerda = new Posicao(Posicao.linha,Posicao.coluna - 1);
                    Posicao direita = new Posicao(Posicao.linha,Posicao.coluna + 1);

                    if (Tabuleiro.posicaoValida(esquerda) && existeInimigo(esquerda) && Tabuleiro.peca(esquerda) == Partida.vulneravelEmPassant) {
                        tabuleiro[esquerda.linha - 1, esquerda.coluna] = true;
                    }

                    if (Tabuleiro.posicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == Partida.vulneravelEmPassant)
                    {
                        tabuleiro[direita.linha - 1, direita.coluna] = true;
                    }
                }
            }
            else
            {
                posicao = new Posicao(Posicao.linha + 1, Posicao.coluna);
                if (Tabuleiro.posicaoValida(posicao) && livre(posicao))
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                posicao = new Posicao(Posicao.linha + 2, Posicao.coluna);
                Posicao posicaoAux = new Posicao(Posicao.linha + 1, Posicao.coluna);
                if (Tabuleiro.posicaoValida(posicaoAux) && livre(posicaoAux) && Tabuleiro.posicaoValida(posicao) && livre(posicao) && qtdMovimentos == 0)
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                posicao = new Posicao(Posicao.linha + 1, Posicao.coluna - 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                posicao = new Posicao(Posicao.linha + 1, Posicao.coluna + 1);
                if (Tabuleiro.posicaoValida(posicao) && existeInimigo(posicao))
                {
                    tabuleiro[posicao.linha, posicao.coluna] = true;
                }

                // #JogadaEspecial (En Passant)
                if (Posicao.linha == 4)
                {
                    Posicao esquerda = new Posicao(Posicao.linha, Posicao.coluna - 1);
                    Posicao direita = new Posicao(Posicao.linha, Posicao.coluna + 1);

                    if (Tabuleiro.posicaoValida(esquerda) && existeInimigo(esquerda) && Tabuleiro.peca(esquerda) == Partida.vulneravelEmPassant)
                    {
                        tabuleiro[esquerda.linha + 1, esquerda.coluna] = true;
                    }

                    if (Tabuleiro.posicaoValida(direita) && existeInimigo(direita) && Tabuleiro.peca(direita) == Partida.vulneravelEmPassant)
                    {
                        tabuleiro[direita.linha + 1, direita.coluna] = true;
                    }
                }
            }

            return tabuleiro;
        }

        private bool existeInimigo(Posicao posicao)
        {
            Peca peca = Tabuleiro.peca(posicao);

            return peca != null && peca.Cor != Cor;
        }

        private bool livre(Posicao posicao)
        {
            return Tabuleiro.peca(posicao) == null;
        }

        private bool podeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.peca(posicao);

            return peca == null || peca.Cor != Cor;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
