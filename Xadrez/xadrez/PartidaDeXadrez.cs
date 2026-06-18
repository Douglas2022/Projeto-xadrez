using System;
using tabuleiro;
using Xadrez.tabuleiro;
using System.Collections.Generic;

namespace xadrez
{
    internal class PartidaDeXadrez
    {
        public Tabuleiro tab { get;private set; }
        public int turno{ get; private set; }
        public Cor JogadorAtual{ get; private set; }
        public bool terminada{ get;private set; }
        private HashSet<Peca>pecas;
        private HashSet<Peca>capturadas;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
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
            executaMovimento(origem,destino);
            turno++;
            mudarJogador();

        }
        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if(tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peca na posicao escolhida");
            }
            if(JogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peca de origem escolhida não é sua");
            }
            if (!tab.peca(pos).existeMovimentosPossivel())
            {
                throw new TabuleiroException("Não há movimentos possiveis na peça de origem escolhida");
            }
        }
        public void validarPosicaoDeDestino(Posicao origem,Posicao destino)
        {
            if (!tab.peca(origem).poderMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }
        private void mudarJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }
        public void colocarNovaPeca(char coluna,int linha,Peca peca)
        {
            tab.colocarPeca(peca,new PosicaoXadrez(coluna,linha).ToPosicao());
            pecas.Add(peca);
        }

        private void colocarPeca()
        {
            colocarNovaPeca('c', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('c', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('d', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('e', 2, new Torre(tab, Cor.Branca));
            colocarNovaPeca('e', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('d', 1, new Rei(tab, Cor.Branca));

            colocarNovaPeca('c', 7, new Torre(tab, Cor.Preta));
            colocarNovaPeca('c', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('d', 7, new Torre(tab, Cor.Preta));
            colocarNovaPeca('e', 7, new Torre(tab, Cor.Preta));
            colocarNovaPeca('e', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('d', 8, new Rei(tab, Cor.Preta));


        }
    }
}
