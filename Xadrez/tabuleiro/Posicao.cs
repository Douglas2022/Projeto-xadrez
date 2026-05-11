namespace tabuleiro
{
    internal class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        public void definirValor(int Linha, int Coluna)
        {
            this.Linha = Linha;
            this.Coluna = Coluna;
        }
        public override string ToString()
        {
            return Linha
                + "," 
                + Coluna;
        }
    }
}
