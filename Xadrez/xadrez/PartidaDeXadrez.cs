using System;
using tabuleiro;
using xadrez;

namespace Xadrez.xadrez
{
    internal class PartidaDeXadrez
    {
        private Tabuleiro tab;
        private int turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            colocarPecas();
        }
        public void executarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();

            Peca pecaCapiturada = tab.retirarPeca(destino);
            tab.colocarPeca(p,destino);
        }
        private void colocarPecas()
        {
            tab.colocarPeca(new Torre(tab,Cor.Preta),new PosicaoXadrez('c',1).toPosicao());
        }
    }
}
