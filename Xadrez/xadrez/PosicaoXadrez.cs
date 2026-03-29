using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {
        public char linha { get; set; }
        public int coluna { get; set; }

        public PosicaoXadrez(char linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
