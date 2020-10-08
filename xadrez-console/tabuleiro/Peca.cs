namespace tabuleiro
{
    public class Peca
    {
        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            this.cor = cor;
            this.qtdMovimentos = 0;
            this.tab = tab;
        }

        public Posicao Posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
    }
}
