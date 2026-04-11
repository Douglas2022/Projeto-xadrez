using tabuleiro;

namespace xadrez
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; }   // letra: a-h
        public int Linha { get; set; }     // número: 1-8

        public PosicaoXadrez(char coluna, int linha)
        {
            this.Coluna = coluna;
            this.Linha = linha;
        }

        // Conversão para índices da matriz
        public Posicao ToPosicao()
        {
            // Linhas: 1 → índice 7, 8 → índice 0
            // Colunas: 'a' → índice 0, 'h' → índice 7
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }
}
