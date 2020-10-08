namespace tabuleiro
{
    public class Peca
    {
        public Peca(Posicao posicao, Cor cor, int qtdMovimentos, Tabuleiro tab)
        {
            Posicao = posicao;
            this.cor = cor;
            this.qtdMovimentos = qtdMovimentos;
            this.tab = tab;
        }

        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
    }
}
