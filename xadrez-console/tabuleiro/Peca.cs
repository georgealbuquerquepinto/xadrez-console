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

        public abstract bool[,] movimentosPossiveis();
    }
}
