using System;
using tabuleiro;
using Xadrez.tabuleiro;


namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get;private set; }
        public int turno;{ get; private set; }
        public Cor JogadorAtual;{ get; private set; }
        public bool terminada { get;private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            terminada = false;
            colocarPeca();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            if(tab.peca(origem) == null)
            {
                throw new TabuleiroException("Não exixte posição de origem");
            }

            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdeMovimentos();
            Peca pecaCapiturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);

        }
        public void realizaJogada(Posicao origem,Posicao destino)
        {
            mudaJogador;
        }
        private void mudarJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca
            }
        }
        private void colocarPeca()
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c',1).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('d', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 7).ToPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
        }
    }
}
