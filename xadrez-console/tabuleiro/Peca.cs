namespace tabuleiro
{
    public abstract class Peca
    {
        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            qtdMovimentos = 0;
            Tabuleiro = tab;
        }

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public void incrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] movimentos = movimentosPossiveis();

            for (int i = 0; i < Tabuleiro.linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.colunas; j++)
                {
                    if (movimentos[i,j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool podeMoverPara(Posicao posicao)
        {
            return movimentosPossiveis()[posicao.linha,posicao.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
