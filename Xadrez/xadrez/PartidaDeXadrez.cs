using System;
using tabuleiro;


namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get; set; }
        private int turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            colocarPeca();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapiturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);

        }
        private void colocarPeca()
        {
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c',1).ToPosicao());
        }
    }
}
