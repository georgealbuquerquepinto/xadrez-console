using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] tabuleiro = new bool[Tabuleiro.linhas, Tabuleiro.colunas];

            Posicao posicao;

            posicao = new Posicao(Posicao.linha - 1, Posicao.coluna - 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            posicao = new Posicao(Posicao.linha - 2, Posicao.coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            posicao = new Posicao(Posicao.linha - 2, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            posicao = new Posicao(Posicao.linha - 1, Posicao.coluna + 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            posicao = new Posicao(Posicao.linha + 1, Posicao.coluna + 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            posicao = new Posicao(Posicao.linha + 2, Posicao.coluna + 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            posicao = new Posicao(Posicao.linha + 2, Posicao.coluna - 1);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
            }

            posicao = new Posicao(Posicao.linha + 1, Posicao.coluna - 2);
            if (Tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                tabuleiro[posicao.linha, posicao.coluna] = true;
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
            return "C";
        }
    }
}
