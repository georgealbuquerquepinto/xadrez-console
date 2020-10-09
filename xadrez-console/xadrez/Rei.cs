using tabuleiro;

namespace xadrez_console.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

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

            return tabuleiro;
        }

        private bool podeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.peca(posicao);

            return peca == null || peca.Cor != Cor;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
