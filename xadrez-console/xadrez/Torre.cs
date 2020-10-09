using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] tabuleiro = new bool[Tabuleiro.linhas, Tabuleiro.colunas];

            Posicao posicao;

            // Norte
            posicao = new Posicao(Posicao.linha - 1, Posicao.coluna);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;

                if(Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.linha -= 1;
            }

            // Sul
            posicao = new Posicao(Posicao.linha + 1, Posicao.coluna);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;

                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.linha += 1;
            }

            // Leste
            posicao = new Posicao(Posicao.linha, Posicao.coluna + 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;

                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.coluna += 1;
            }

            // Oeste
            posicao = new Posicao(Posicao.linha, Posicao.coluna - 1);
            while (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;

                if (Tabuleiro.peca(posicao) != null && Tabuleiro.peca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.coluna -= 1;
            }

            return tabuleiro;
        }

        private bool podeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.peca(posicao);

            return peca == null || peca.Cor != Cor;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
